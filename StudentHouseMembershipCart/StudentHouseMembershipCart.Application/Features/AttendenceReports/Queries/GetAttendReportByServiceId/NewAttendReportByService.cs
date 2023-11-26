using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByServiceId
{
    public class NewAttendReportByService
    {
        public Guid AttendId { get; set; }
        public Guid? FeedBackId { get; set; }
        public string? AttendTittle { get; set; }
        /// <summary>
        /// Ngày nhận việc (giống như giặt quần áo thì sẽ có ngày nhận việc) hoặc ngày làm việc
        /// </summary>
        public DateTime DateDoService { get; set; }
        public string? ApartmentRegion { get; set; }
        public string? FeedbackAvailable { get; set; }
        public string?  FeedbackStatus { get; set; }
        public Guid ServiceId { get; set; }
        /// <summary>
        /// Có thể là Service hoặc Package Đều được
        /// </summary>
        public Guid BookingDetailId { get; set; }
        /// <summary>
        /// 1. Package
        /// 2. Service
        /// </summary>
        public string? AttendReportForType { get; set; }
        public Guid? ReportWorkId { get; set; }
        /// <summary>
        /// 0. Is Not Finish
        /// 1. Is Finish by Staff
        /// 2. Is Feedbacked by User
        /// </summary>
        public int? AttendenceStatus { get; set; }
        public string? Note { get; set; }
    }
}
