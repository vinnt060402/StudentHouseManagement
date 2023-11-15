using MediatR;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByApartmentId
{
    public class GetAttendReportByApartmentIdCommand : IRequest<List<AttendReportData>>
    {
        public string BookingDetailId { get; set; } = null!;
    }
}