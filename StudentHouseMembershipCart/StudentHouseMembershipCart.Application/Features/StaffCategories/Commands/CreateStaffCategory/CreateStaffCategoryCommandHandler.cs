using MediatR;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.CreateStaffCategory
{
    public class CreateStaffCategoryCommandHandler : IRequestHandler<CreateStaffCategoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreateStaffCategoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreateStaffCategoryCommand request, CancellationToken cancellationToken)
        {
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
                Message = Extensions.CreateSuccessfully
            };
        }
    }
}