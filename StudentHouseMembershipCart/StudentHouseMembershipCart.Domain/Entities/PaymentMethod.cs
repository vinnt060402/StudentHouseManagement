using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class PaymentMethod : BaseAuditableEntity 
    { 
        public string PaymentMethodName { get; set; }

        [ForeignKey("Role")]
        public Guid BookingId { get; set; }

        // relationShip
        public virtual Booking Booking { get; set; }

    }

}
