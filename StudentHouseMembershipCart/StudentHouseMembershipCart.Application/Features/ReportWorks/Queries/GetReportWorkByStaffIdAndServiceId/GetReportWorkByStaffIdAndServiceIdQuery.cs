using MediatR;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByStaffIdAndServiceId
{
    public class GetReportWorkByStaffIdAndServiceIdQuery : IRequest<List<ReportWorkData>>
    {
        public Guid StaffId { get; set; }
        public Guid ServiceId {  get; set; }    
    }
}
