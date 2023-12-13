using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class BookingDetailOfService : BaseAuditableEntity
    {
        /// <summary>
        /// Ngay bat dau dich vu
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Ngay ket thuc dich vu
        /// </summary>
        public DateTime? EndDate { get; set; }/*
        /// <summary>
        /// This variable is mean that total price of
        /// package price * quantiy of package ordered 
        /// If booking detail is renewed, it will be add on
        /// </summary>
        public double TotalPriceOfQuantity { get; set; }*/
        public bool IsRe_Newed { get; set; }
        public DateTime? RenewStartDate { get; set; }

        /// <summary>
        /// The same with total price of booking det
        /// </summary>
        public int QuantityOfPackageOrdered { get; set; }
        /// <summary>
        /// 0. On going
        /// 1. Finished
        /// </summary>
        public int? BookingDetailStatus { get; set; }
        /// <summary>
        /// Booking Id is Contract Id
        /// </summary>
        [ForeignKey("Booking")]
        public Guid BookingId { get; set; }
        [ForeignKey("Service")]
        public Guid ServiceId { get; set; }

        // relationShip
        public virtual Booking Booking { get; set; }
        public virtual Service Service { get; set; }
        public IList<AttendReport> AttendReport { get; private set; }
        public IList<ServiceRemainingTaskDuration> ServiceRemainingTaskDuration { get; private set; }
        public IList<BookingDetailStaff> BookingDetailStaff { get; private set; }
    }
}
