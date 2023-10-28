using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Student : BaseAuditableEntity
    {
        public DateTime? Birthday { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }


        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }

        public IList<FeedBack>? FeedBack { get; set; }

        public IList<Apartment>? Apartment { get; private set; }
    }

}
