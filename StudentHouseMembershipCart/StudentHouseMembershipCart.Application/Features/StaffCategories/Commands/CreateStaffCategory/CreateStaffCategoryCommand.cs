using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.CreateStaffCategory
{
    public class CreateStaffCategoryCommand : IRequest<SHMResponse>
    {
        public List<string> ListCategoryId { get; set; } = null!;
        public string StaffId { get; set; } = null!;
    }
}