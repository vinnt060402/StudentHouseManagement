using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.DeleteStaffCategoryByStaffId
{
    public class DeleteStaffCategoryByStaffIdComand : IRequest<SHMResponse>
    {
        public string StaffId { get; set; } = null!;
    }
}