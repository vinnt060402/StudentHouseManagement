using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.UpdateStaffCategory
{
    public class UpdateStaffCategoryCommand : IRequest<SHMResponse>
    {
        public List<string> ListCategoryId { get; set; } = null!;
        public string StaffId { get; set; } = null!;
    }
}