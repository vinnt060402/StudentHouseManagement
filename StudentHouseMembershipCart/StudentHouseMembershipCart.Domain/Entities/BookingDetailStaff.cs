using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class BookingDetailStaff : BaseAuditableEntity 
    {
        [ForeignKey("BookingDetail")]
        public Guid BookingDetailId { get; set; }
        [ForeignKey("Staff")]
        public Guid StaffId { get; set; } 

        // relationShip
        public virtual BookingDetail BookingDetail { get; set; }
        public virtual Staff Staff { get; set; }
    }

}
