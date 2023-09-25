using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class AttendReportRepository : GenericRepository<AttendReport>, IAttendReportRepository
    {
        public AttendReportRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
