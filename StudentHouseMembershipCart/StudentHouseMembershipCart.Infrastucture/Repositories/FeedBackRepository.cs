using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class FeedBackRepository : GenericRepository<FeedBack>, IFeedBackRepository
    {
        public FeedBackRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
