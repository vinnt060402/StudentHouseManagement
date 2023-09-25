using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Staff : BaseAuditableEntity 
    { 
        public string staffName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        // relationShip
        public virtual Role Role { get; set; }

        public IList<BookingDetailStaff> BookingDetailStaff { get; private set; }
        public IList<ReportWork> ReportWork { get; private set; }

    }

}
