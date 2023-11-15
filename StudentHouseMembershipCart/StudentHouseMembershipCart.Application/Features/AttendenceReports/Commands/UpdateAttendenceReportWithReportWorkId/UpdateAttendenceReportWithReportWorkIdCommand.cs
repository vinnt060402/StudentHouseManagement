using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.UpdateAttendenceReportWithReportWorkId
{
    public class UpdateAttendenceReportWithReportWorkIdCommand : IRequest<SHMResponse>
    {
        public string AttendenceReportId { get; set; } = null!;
        public string ReportWorkId { get; set; } = null!;
    }
}