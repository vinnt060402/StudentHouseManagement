using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport
{
    public class CreateAttendenceReportCommand : IRequest<SHMResponse>
    {
        public Guid StudentId { get; set; }
        public DateTime StartDay { get; set; }
        public string DayDoBookingDetailInWeek { get; set; } = null!;
        public int TotalDayNeedWork { get; set; }
        public int TotalDayWorkingInWeek { get; set; }
        public string BookingDetailId { get; set; } = null!;
    }
}