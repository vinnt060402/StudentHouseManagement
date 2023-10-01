using StudentHouseMembershipCart.Application.Models.Identity;

namespace StudentHouseMembershipCart.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<List<EndUser>> GetUsers();
        Task<EndUser> GetUser(string userId);
    }
}
