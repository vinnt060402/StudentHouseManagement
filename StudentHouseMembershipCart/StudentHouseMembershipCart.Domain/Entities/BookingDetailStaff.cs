using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class BookingDetailStaff : BaseAuditableEntity 
    {
        /// <summary>
        /// Có thể là service hoặc package
        /// </summary>
        public Guid BookingDetailId { get; set; }
        [ForeignKey("Staff")]
        public Guid StaffId { get; set; } 

        // relationShip
        public virtual Staff Staff { get; set; }
    }

}
