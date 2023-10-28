using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Staff : BaseAuditableEntity 
    { 
        public string? staffName { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
        public IList<BookingDetailStaff> BookingDetailStaff { get; private set; }
        public IList<StaffCategory> StaffCategories { get; set; }
        public IList<ReportWork> ReportWork { get; private set; }

    }

}
