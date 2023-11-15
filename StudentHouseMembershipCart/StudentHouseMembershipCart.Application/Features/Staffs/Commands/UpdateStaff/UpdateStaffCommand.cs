using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.UpdateStaff
{
    public class UpdateStaffCommand : IRequest<SHMResponse>
    {
        public List<string> ListCategoryId { get; set; } = null!;
        public Guid StaffId { get; set; }

        public string? FullName { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
    }
}