using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class PackageService : BaseAuditableEntity 
    {
        [ForeignKey("Package")]
        public Guid PackageId { get; set; }
        [ForeignKey("Service")]
        public Guid ServiceId { get; set; }
        public int? QuantityOfService { get; set; }

        // relationShip
        public virtual Package Package { get; set; }
        public virtual Service Service { get; set; }

    }

}
