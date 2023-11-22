using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.PackageServices.Commands.DeletePackageServiceCommand;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.DeleteFP
{
    public class DeletePackageCommandHandler : IRequestHandler<DeletePackageCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public DeletePackageCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
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
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                package.IsDelete = true;
                _dbContext.Package.Update(package);
                var deletePackageServiceRequest = new DeletePackageServiceCommand()
                {
                    PackageId = request.PackageId,
                };
                var deletePackageServiceResponse = await _mediator.Send(deletePackageServiceRequest);
                await _dbContext.SaveChangesAsync();
                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}