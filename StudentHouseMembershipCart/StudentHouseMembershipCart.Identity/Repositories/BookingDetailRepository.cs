using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class BookingDetailRepository : GenericRepository<BookingDetail>, IBookingDetailRepository
    {
        public BookingDetailRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
