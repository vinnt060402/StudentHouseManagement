using MediatR;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.DeleteStaff
{
    public class DeleteStaffCommandHandler : IRequestHandler<DeleteStaffCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public DeleteStaffCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(DeleteStaffCommand request, CancellationToken cancellationToken)
        {
            var staff = _dbContext.Staff.Where(x => x.Id == request.Id).SingleOrDefault();
            if (staff == null)
            {
                throw new NotFoundException("The staff have not been found!");
            }
            if (staff.IsDelete == true)
            {
                throw new NotFoundException("The staff have been deleted!");
            }
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                staff.IsDelete = true;
                _dbContext.Staff.Update(staff);
                await _dbContext.SaveChangesAsync();
                scope.Complete();
            }
            return new SHMResponse
            {
                Message = "Delete successfully!"
            };
        }
    }
}
