using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class BookingDetail : BaseAuditableEntity 
    { 
        public string BookingDetailName { get; set; } = null!;
        public double Price { get; set; }
        public bool IsRe_Newed { get; set; }
        public DateTime? RenewStartDate { get; set; }
        public int remainingTaskDuration { get; set; }  
        public string ContractName { get; set; } = null!;
        public string ContractDescription { get; set; } = null!;

        [ForeignKey("Booking")]
        public Guid BookingId { get; set; }
        [ForeignKey("Package")]
        public Guid PackageId { get; set; }

        // relationShip
        public virtual Booking Booking { get; set; }
        public virtual Package Package { get; set; }
        public IList<AttendReport> AttendReport { get; private set; }
        public IList<BookingDetailStaff> BookingDetailStaff { get; private set; }

    }

}
