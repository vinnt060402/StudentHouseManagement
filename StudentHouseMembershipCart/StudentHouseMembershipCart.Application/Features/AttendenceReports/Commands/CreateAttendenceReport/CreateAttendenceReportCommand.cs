using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport
{
    public class CreateAttendenceReportCommand : IRequest<SHMResponse>
    {
        public string ServiceId { get; set; } = null!;
        public int FrequencyDaysPerOccurrence { get; set; } 
        public DateTime DateDoService { get; set; }
        /// <summary>
        /// Chu Kỳ làm việc
        /// Chỉ lần này: 1
        /// 1 Tuần: 7
        /// 1 Tháng 30
        /// 3 Tháng 90
        /// 6 Tháng 180 
        /// </summary>
        public int WorkingCycle { get; set; } 
        public string BookingDetailId { get; set; } = null!;
        public string BookingDetailType { get; set; } = null!;  
        public int QuantityDoService { get; set; }  
        public string? Note { get; set; }
    }
}