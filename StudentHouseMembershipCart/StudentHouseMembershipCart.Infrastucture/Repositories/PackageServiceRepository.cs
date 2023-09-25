using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class PackageServiceRepository : GenericRepository<PackageService>, IPackageServiceRepository
    {
        public PackageServiceRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
