using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.CreatePackageServiceCommand
{
    public class CreatePackageServiceCommandHandler : IRequestHandler<CreatePackageServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreatePackageServiceCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreatePackageServiceCommand request, CancellationToken cancellationToken)
        {
            var serviceExisted = await _dbContext.Service.AsNoTracking().Where(x => request.ListServiceWithQuantity.Select(x => x.ServiceId).Contains(x.Id)).ToListAsync();
            if (!serviceExisted.Any())
            {
                throw new NotFoundException("Have no service like this before!!");
            }
            var packageExisted = await _dbContext.PackageService.Where(x => x.PackageId == request.PackageId &&
                                                                            request.ListServiceWithQuantity.Select(x => x.ServiceId).Contains(x.Id)).ToListAsync();
            if (packageExisted.Any())
            {
                throw new BadRequestException("The package have already existed!");
            }
            var listPackageService = new List<PackageService>();
            foreach (var serviceId in request.ListServiceWithQuantity)
            {
                var packageItem = new PackageService
                {
                    PackageId = request.PackageId,
                    ServiceId = serviceId.ServiceId,
                    QuantityOfService = serviceId.Quantity,
                    IsDelete = false,
                };
                listPackageService.Add(packageItem);
            }
            _dbContext.PackageService.AddRange(listPackageService);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
    }
}