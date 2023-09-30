using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class ReportWorkeRepository : GenericRepository<ReportWork>, IReportWorkRepository
    {
        public ReportWorkeRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
