using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories;
public class PackageRepository : GenericRepository<Package>, IPackageRepository
{
    public PackageRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
    {
    }
}

