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
        [ForeignKey("PaymentNew")]
        public string PaymentNewId { get; set; } = null!;
        /// <summary>
        /// 0. On going
        /// 1. Finished
        /// </summary>
        public int? StatusContract { get; set; }

        // relationShip
        public virtual PaymentNew PaymentNew { get; set; } 
        public virtual Apartment Apartment { get; set; }
        public IList<BookingDetailOfPakcage> BookingDetailOfPakcage { get; private set; }
        public IList<BookingDetailOfService> BookingDetailOfService { get; private set; }


    }

}
