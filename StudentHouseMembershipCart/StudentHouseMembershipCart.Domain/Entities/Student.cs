using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Student : BaseAuditableEntity
    {
        public string StudentName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
        [ForeignKey("FeedBack")]
        public Guid FeedbackId { get; set; }

        // relationShip
        public virtual Role Role { get; set; }
        public virtual FeedBack FeedBacks { get; set; }

        public IList<Apartment> Apartment { get; private set; }
        public IList<FeedBack> FeedBack { get; private set; }
    }

}
