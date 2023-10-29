using MediatR;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByBookingDetailId
{
    public class GetAttendReportByBookingDetailIdCommand : IRequest<List<AttendReportData>>
    {
        public Guid BookingDetailId { get; set; }   
    }
}
