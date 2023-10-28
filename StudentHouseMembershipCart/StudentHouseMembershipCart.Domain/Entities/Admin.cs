using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Admin : BaseAuditableEntity 
    {

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public string AdminName { get; set; }

        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
        

    }

}
