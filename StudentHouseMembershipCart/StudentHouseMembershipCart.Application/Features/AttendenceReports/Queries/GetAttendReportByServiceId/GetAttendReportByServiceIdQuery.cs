using MediatR;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByServiceId
{
    public class GetAttendReportByServiceIdQuery : IRequest<List<NewAttendReportByService>>
    {
        public Guid StudentId { get; set; }   
        public Guid ServiceId {  get; set; }
    }
}
