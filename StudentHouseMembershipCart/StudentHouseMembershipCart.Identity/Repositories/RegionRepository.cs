using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
