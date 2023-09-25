using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Admin : BaseAuditableEntity 
    { 
        public string AdminName { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        // relationShip
        public virtual Role Role { get; set; }
        public IList<Package> Package { get; private set; }

    }

}
