using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class StaffCategory : BaseAuditableEntity
    {
        [ForeignKey("Staff")]
        public Guid StaffId { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Category Category { get; set; }

    }
}
