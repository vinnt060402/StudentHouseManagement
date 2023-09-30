using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Auth.Queries.ChangePassword
{
    public class ChangePasswordQuery : IRequest<string>
    {
        public string? Email { get; set; }
        public string? CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
    }
}
