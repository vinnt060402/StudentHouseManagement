using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class ServiceRepository : GenericRepository<Domain.Entities.Service>, IServiceRepository
    {
        public ServiceRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
