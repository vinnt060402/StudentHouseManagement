using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class FeedBackRepository : GenericRepository<FeedBack>, IFeedBackRepository
    {
        public FeedBackRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
