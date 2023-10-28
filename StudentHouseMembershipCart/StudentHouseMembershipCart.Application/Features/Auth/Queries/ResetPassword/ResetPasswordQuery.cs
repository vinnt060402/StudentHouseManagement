using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Auth.Queries.ResetPassword
{
    public class ResetPasswordQuery : IRequest<string>
    {
        public string? Email { get; set; }
    }
}
