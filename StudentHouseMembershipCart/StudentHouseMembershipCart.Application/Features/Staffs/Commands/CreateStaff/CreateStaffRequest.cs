using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;
using System.ComponentModel.DataAnnotations;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.CreateStaff
{
    public class CreateStaffRequest : IRequest<SHMResponse>
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
