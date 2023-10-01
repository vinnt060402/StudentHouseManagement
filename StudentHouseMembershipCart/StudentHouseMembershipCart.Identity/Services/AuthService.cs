using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Contracts.Identity;
using StudentHouseMembershipCart.Application.Models.Identity;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentHouseMembershipCart.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _siginInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> siginInManager,
            IOptions<JwtSettings> jwtSettings)
        {
            this._userManager = userManager;
            this._siginInManager = siginInManager;
            this._jwtSettings = jwtSettings.Value;
        }
        public async Task<AuthResponse> Login(AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new NotFoundException($"User with {request.Email} not found.", request.Email);
            }

            var result = await _siginInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (result.Succeeded == false)
            {
                throw new BadRequestException($"Credentials for '{request.Email} aren't valid '.");
            }

            JwtSecurityToken jwtSecurityToken = await GenerateToken(user);

            var response = new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Email = user.Email,
                UserName = user.UserName
            };
            return response;
        }

        public async Task<RegistrationResponse> Register(RegistrationRequest request, String role)
        {
            var userExist = await _userManager.FindByEmailAsync(request.Email);
            if (userExist != null)
            {
                throw new BadRequestException($"Email {request.Email} is Existed!!");
            }
            var user = new ApplicationUser
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                EmailConfirmed = true,
            };
            try
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                await _userManager.AddToRoleAsync(user, role);
                return new RegistrationResponse() { UserId = user.Id };
            }
            catch (BadRequestException ex)
            {
                throw new BadRequestException(ex.ToString());
            }
        }

        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

            var sigingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(7).AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: sigingCredentials);
            return jwtSecurityToken;
        }
    }
}
