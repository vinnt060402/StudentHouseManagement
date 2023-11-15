using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.CreateStaff
{
    public class CreateStaffRequest : IRequest<SHMResponse>
    {
        public List<string> ListCategoryId { get; set; } = null!;
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public string? Phone { get; set; }

        public string? Address { get; set; }

        public DateTime? Birthday { get; set; }
    }
}