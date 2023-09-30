using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class AttendReportRepository : GenericRepository<AttendReport>, IAttendReportRepository
    {
        public AttendReportRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
