using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class PaymentHistory : BaseAuditableEntity 
    {
        [ForeignKey("PaymentMethod")]
        public Guid PaymentMethodId { get; set; }

        [ForeignKey("Booking")]
        public Guid BookingId { get; set; }

        public double? Amount { get; set; }
        /// <summary>
        /// 0. Paid
        /// 1. Have not paid
        /// </summary>
        public int PaymentStatus { get; set; }

        // relationShip
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Booking Booking { get; set; }

    }

}
