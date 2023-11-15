using MediatR;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.DeleteStaffCategoryByStaffId;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.DeleteStaff
{
    public class DeleteStaffCommandHandler : IRequestHandler<DeleteStaffCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public DeleteStaffCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
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
                staff.LastModifiedBy = request.DeleteBy;
                staff.LastModified = DateTime.Now;
                _dbContext.Staff.Update(staff);
                await _dbContext.SaveChangesAsync();

                var deleteStaffCategory = new DeleteStaffCategoryByStaffIdComand
                {
                    StaffId = request.Id.ToString()
                };
                var deleteStaffCategoryResponse = await _mediator.Send(deleteStaffCategory);
                if (deleteStaffCategoryResponse == null || deleteStaffCategoryResponse.Message != Extensions.DeleteSuccessfully)
                {
                    throw new BadRequestException("Can not delete Staff Staff");
                }

                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}