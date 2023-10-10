using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP
{
    public class UpdatePackageCommandHandler : IRequestHandler<UpdatePackageCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdatePackageCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdatePackageCommand request, CancellationToken cancellationToken)
        {
            var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(request.PackageId)).SingleOrDefaultAsync();
            if (package == null)
            {
                throw new NotFoundException("The category have not existed!");
            }
            if (package.IsDelete)
            {
                throw new BadRequestException("The category have been deleted!");
            }
            package.PackageName = request.PackageName ?? package.PackageName;
            package.LastModified = DateTime.Now;
            package.LastModifiedBy = request.UpdateBy ?? package.LastModifiedBy;
            _dbContext.Package.Update(package);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}
