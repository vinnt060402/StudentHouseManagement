using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Asn1.Ocsp;
using StudentHouseMembershipCart.Application.Contracts.Identity;
using StudentHouseMembershipCart.Application.Models.Identity;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        /*private readonly IHttpContextAccessor _httpContextAccessor;*/

        public UserService(UserManager<ApplicationUser> userManager/*, IHttpContextAccessor httpContextAccessor*/)
        {
            _userManager = userManager;
            /*_httpContextAccessor = httpContextAccessor;*/
        }

        /*public string UserId { get => _httpContextAccessor.HttpContext?.User?.FindFirstValue("uid"); }*/

        public async Task<EndUser> GetUser(string userId)
        {
            var endUser = await _userManager.FindByIdAsync(userId);
            return new EndUser
            {
                Email = endUser.Email,
                Id = endUser.Id,
                FullName = endUser.FullName,
            };
        }

        public async Task<List<EndUser>> GetUsers()
        {
            var endUser = await _userManager.GetUsersInRoleAsync("EndUser");
            return endUser.Select(q => new EndUser
            {
                Id = q.Id,
                Email = q.Email,
                FullName = q.FullName,
            }).ToList();
        }
    }
}
