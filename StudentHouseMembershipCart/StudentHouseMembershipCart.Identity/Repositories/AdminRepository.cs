using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
