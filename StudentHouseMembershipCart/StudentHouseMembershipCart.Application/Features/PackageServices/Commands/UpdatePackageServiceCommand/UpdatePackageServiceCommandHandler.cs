using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.UpdatePackageServiceCommand
{
    public class UpdatePackageServiceCommandHandler : IRequestHandler<UpdatePackageServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdatePackageServiceCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdatePackageServiceCommand request, CancellationToken cancellationToken)
        {
            var serviceExisted = await _dbContext.Service.AsNoTracking().Where(x => request.ListServiceId.Contains(x.Id)).ToListAsync();
            if (!serviceExisted.Any())
            {
                throw new NotFoundException("Have no service like this before!!");
            }
            var packageServiceList = await _dbContext.PackageService.Where(x => x.PackageId == request.PackageId).ToListAsync();
            var localCreated = packageServiceList.Select(x => x.Created).FirstOrDefault();
            var localCreateBy = packageServiceList.Select(x => x.CreateBy).FirstOrDefault();
            _dbContext.PackageService.RemoveRange(packageServiceList);
            var listPackageService = new List<PackageService>();
            foreach (var serviceId in request.ListServiceId)
            {
                var packageItem = new PackageService
                {
                    PackageId = request.PackageId,
                    ServiceId = serviceId,
                    QuantityOfService = request.Quantity,
                    Created = localCreated,
                    CreateBy = localCreateBy,
                    IsDelete = false,
                };
                listPackageService.Add(packageItem);
            }
            _dbContext.PackageService.AddRange(listPackageService);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}