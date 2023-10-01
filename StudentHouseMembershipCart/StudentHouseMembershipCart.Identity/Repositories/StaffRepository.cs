using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
