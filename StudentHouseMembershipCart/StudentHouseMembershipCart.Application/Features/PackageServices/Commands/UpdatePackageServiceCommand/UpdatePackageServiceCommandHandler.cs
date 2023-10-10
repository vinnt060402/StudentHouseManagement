using MediatR;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.UpdatePackageServiceCommand
{
    public class UpdatePackageServiceCommandHandler : IRequestHandler<UpdatePackageServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdatePackageServiceCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<SHMResponse> Handle(UpdatePackageServiceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
