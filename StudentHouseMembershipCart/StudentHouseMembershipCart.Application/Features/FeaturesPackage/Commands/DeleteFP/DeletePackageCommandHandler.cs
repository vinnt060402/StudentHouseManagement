using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.DeleteFP
{
    public class DeletePackageCommandHandler : IRequestHandler<DeletePackageCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public DeletePackageCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(DeletePackageCommand request, CancellationToken cancellationToken)
        {
            var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(request.PackageId)).SingleOrDefaultAsync();
            if (package == null)
            {
                throw new NotFoundException("The package have not existed!");
            }
            if (package.IsDelete)
            {
                throw new BadRequestException("The package have been deleted!");
            }
            package.IsDelete = true;
            package.LastModified = DateTime.Now;
            package.LastModifiedBy = request.DeleteBy;
            _dbContext.Package.Update(package);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}
