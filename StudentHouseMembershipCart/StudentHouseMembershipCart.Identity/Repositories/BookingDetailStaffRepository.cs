using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class BookingDetailStaffRepository : GenericRepository<BookingDetailStaff>, IBookingDetailStaffRepository
    {
        public BookingDetailStaffRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
