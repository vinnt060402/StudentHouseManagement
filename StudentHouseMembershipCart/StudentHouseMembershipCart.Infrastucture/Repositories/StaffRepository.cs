using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
