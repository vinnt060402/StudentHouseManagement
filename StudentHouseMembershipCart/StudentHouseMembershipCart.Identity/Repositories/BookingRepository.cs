using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
