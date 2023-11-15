using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.UpdateStaffCategory;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.UpdateStaff
{
    public class UpdateStaffCommandHandler : IRequestHandler<UpdateStaffCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private IMapper _mapper;
        private IMediator _mediator;

        public UpdateStaffCommandHandler(IApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(UpdateStaffCommand request, CancellationToken cancellationToken)
        {
            var staff = _dbContext.Staff.AsNoTracking().Where(x => x.Id == request.StaffId).SingleOrDefault();
            if (staff == null)
            {
                throw new NotFoundException("Staff ID does not exist!!!");
            }
            if (staff.IsDelete)
            {
                throw new NotFoundException("The staff have been deleted");
            }
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                staff.staffName = request.FullName ?? staff.staffName;
                staff.Birthday = request.Birthday ?? staff.Birthday;
                staff.Address = request.Address ?? staff.Address;

                var applicationStaff = await _userManager.FindByIdAsync(staff.ApplicationUserId);

                applicationStaff.FullName = request.FullName ?? (applicationStaff.FullName ?? null);
                applicationStaff.PhoneNumber = request.Phone ?? (applicationStaff.PhoneNumber ?? null);

                await _userManager.UpdateAsync(applicationStaff);
                _dbContext.Staff.Update(staff);
                await _dbContext.SaveChangesAsync();
                scope.Complete();
                var updateStaffCategoryRequest = new UpdateStaffCategoryCommand
                {
                    ListCategoryId = request.ListCategoryId,
                    StaffId = staff.Id.ToString()
                };
                var updateStaffCategoryResponse = await _mediator.Send(updateStaffCategoryRequest);
                if (updateStaffCategoryResponse.Message != Extensions.UpdateSuccessfully || updateStaffCategoryResponse == null)
                {
                    throw new BadRequestException("Can not update Staff Staff");
                }
            }
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}