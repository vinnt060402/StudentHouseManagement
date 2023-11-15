using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using System.Security.Cryptography.X509Certificates;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.DeletePackageServiceCommand
{
    public class DeletePackageServiceCommandHandler : IRequestHandler<DeletePackageServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public DeletePackageServiceCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(DeletePackageServiceCommand request, CancellationToken cancellationToken)
        {
            var listPackageService = await _dbContext.PackageService.Where(x => x.PackageId == Guid.Parse(request.PackageId)).ToListAsync();
            if (!listPackageService.Any())
            {
                throw new NotFoundException("Can not find this list package service!");
            }
            if (listPackageService.Select(x => x.IsDelete).FirstOrDefault())
            {
                throw new BadRequestException("This list package service have been deleted before!");
            }
            foreach (var packageService in listPackageService)
            {
                packageService.IsDelete = true;
            }
            _dbContext.PackageService.UpdateRange(listPackageService);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}