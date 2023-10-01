using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class PackageServiceRepository : GenericRepository<PackageService>, IPackageServiceRepository
    {
        public PackageServiceRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
