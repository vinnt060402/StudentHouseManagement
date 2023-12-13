using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class ServiceRemainingTaskDuration :  BaseAuditableEntity
    {
        [ForeignKey("Service")]
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
        /// <summary>
        /// Số lượng 
        /// </summary>
        public int RemainingTaskDuration { get; set; }
        public virtual Service Service { get; set; }
    }
}
