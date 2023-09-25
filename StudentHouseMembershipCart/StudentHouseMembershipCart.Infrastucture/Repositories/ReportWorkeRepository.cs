using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class ReportWorkeRepository : GenericRepository<ReportWork>, IReportWorkRepository
    {
        public ReportWorkeRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
