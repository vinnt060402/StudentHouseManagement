using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class BookingDetailRepository : GenericRepository<BookingDetail>, IBookingDetailRepository
    {
        public BookingDetailRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
