using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class ReportWork : BaseAuditableEntity 
    { 
        public string DescriptionProcess { get; set; }
        public string Image { get; set; }

        [ForeignKey("Staff")]
        public Guid StaffId { get; set; }

        // relationShip
        public virtual Staff Staff { get; set; }
        public IList<AttendReport> AttendReport { get; private set; }
    }

}
