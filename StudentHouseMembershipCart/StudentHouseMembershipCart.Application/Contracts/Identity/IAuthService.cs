using StudentHouseMembershipCart.Application.Models.Identity;

namespace StudentHouseMembershipCart.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request, String role);
    }
}
