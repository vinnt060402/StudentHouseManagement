using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.UpdateReportWorkByStaff
{
    /// <summary>
    /// Use to UPDATE PROCESS TASK
    /// </summary>
    public class UpdateReportWorkByStaffCommand : IRequest<SHMResponse>
    {
        public Guid StaffId { get; set; }
        public Guid AttendReportId { get; set; }
        public string? DescriptionProcess { get; set; }
        public string ImageURL { get; set; } = null!;
        public DateTime WorkingDayReport { get; set; }
    }
}