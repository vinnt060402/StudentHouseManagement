using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Booking : BaseAuditableEntity
    {
        public string Contract { get; set; } = null!;
        public double TotalPay { get; set; }    
        public DateTime StartDate { get; set; }

        [ForeignKey("Apartment")]
        public Guid ApartmentId { get; set; }
        /// <summary>
        /// 0. On going
        /// 1. Finished
        /// </summary>
        public int? StatusContract { get; set; }

        // relationShip
        public virtual Apartment Apartment { get; set; }
        public IList<BookingDetail> BookingDetail { get; private set; }
        public IList<PaymentHistory> PaymentMethod { get; private set; }


    }

}
