using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class AttendReport : BaseAuditableEntity 
    { 
        public DateTime DateDoPackage { get; set; }

        [ForeignKey("Service")]
        public Guid ServiceId { get; set; }
        /// <summary>
        /// Có thể là Service hoặc Package Đều được
        /// </summary>
        public Guid BookingDetailId { get; set; }
        public Guid? ReportWorkId { get; set; }
        /// <summary>
        /// 0. Is Not Finish
        /// 1. Is Finish by Staff
        /// 2. Is Feedbacked by User
        /// </summary>
        public int? AttendenceStatus { get; set; }
        /*[ForeignKey("FeedBack")]
        public Guid FeedbackId { get; set; } */

        // relationShip
        public virtual Service Service { get; set; }
        public virtual FeedBack FeedBack { get; set; }

    }

}

