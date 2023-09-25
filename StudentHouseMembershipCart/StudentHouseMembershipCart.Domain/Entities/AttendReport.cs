using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class AttendReport : BaseAuditableEntity 
    {
        public DateTime DateDoPackage { get; set; }

        [ForeignKey("BookingDetail")]
        public Guid BookingDetailId { get; set; }
        [ForeignKey("ReportWork")]
        public Guid ReportWorkId { get; set; }
        [ForeignKey("FeedBack")]
        public Guid FeedbackId { get; set; } 

        // relationShip
        public virtual BookingDetail BookingDetail { get; set; }
        public virtual ReportWork ReportWork { get; set; }
        public virtual FeedBack FeedBacks { get; set; }

        public IList<FeedBack> FeedBack { get; private set; }

    }

}
