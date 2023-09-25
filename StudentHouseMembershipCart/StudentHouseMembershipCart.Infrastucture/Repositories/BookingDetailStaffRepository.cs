using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class BookingDetailStaffRepository : GenericRepository<BookingDetailStaff>, IBookingDetailStaffRepository
    {
        public BookingDetailStaffRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
