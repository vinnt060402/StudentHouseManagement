using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class ReportWork : BaseAuditableEntity 
    { 
        /// <summary>
        /// Đánh dấu ngày staff đi làm đươc generate tự động bởi BookingDetailStaff
        /// </summary>
        public DateTime? WorkingDayExpect { get; set; }
        public string? DescriptionProcess { get; set; }
        public string? Image { get; set; }
        /// <summary>
        /// Id của staff được nhờ làm giúp
        /// </summary>
        public Guid? StaffSubstitableId { get; set; }
        /// <summary>
        /// Lý do tại sao nhờ làm giúp
        /// </summary>
        public string? AlternativeReason { get; set; }
        /// <summary>
        /// 0. Chưa làm
        /// 1. Đã làm
        /// </summary>
        public int WorkingStatus { get; set; } = 0;
        /// <summary>
        /// Ngày làm cái bookingdetail 
        /// </summary>
        public DateTime? WorkingDayReport { get; set; }
        /// <summary>
        /// Đánh dấu được report bởi staff nào
        /// Bởi vì có thể nhờ staff khác làm giùm nên mới thêm field này
        /// </summary>
        public Guid? ReportByStaffId { get; set; }

        [ForeignKey("Staff")]
        public Guid StaffId { get; set; }
        [ForeignKey("AttendReport")]
        public Guid AttendReportId { get; set; }

        // relationShip
        public virtual Staff Staff { get; set; }
        public virtual AttendReport AttendReport { get; set; }
    }

}
