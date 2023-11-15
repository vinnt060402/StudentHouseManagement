using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.UpdateStaffCategory
{
    public class UpdateStaffCategoryCommandHandler : IRequestHandler<UpdateStaffCategoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdateStaffCategoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdateStaffCategoryCommand request, CancellationToken cancellationToken)
        {
            var listStaffCategory = await _dbContext.StaffCategory.Where(x => x.StaffId == Guid.Parse(request.StaffId)).ToListAsync();
            if (listStaffCategory.Any())
            {
                _dbContext.StaffCategory.RemoveRange(listStaffCategory);
            }
            List<StaffCategory> staffCategories = new List<StaffCategory>();
            foreach (var category in request.ListCategoryId)
            {
                var staffCategory = new StaffCategory
                {
                    CategoryId = Guid.Parse(category),
                    StaffId = Guid.Parse(request.StaffId)
                };
                staffCategories.Add(staffCategory);
            }
            _dbContext.StaffCategory.AddRange(staffCategories);
            await _dbContext.SaveChangesAsync();

            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}