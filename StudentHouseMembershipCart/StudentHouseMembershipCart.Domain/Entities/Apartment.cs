using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Apartment : BaseAuditableEntity
    {
        public string Address { get; set; } = null!;
        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Region")]
        public Guid RegionId { get; set; }

        //Relationship
        public virtual Student Student { get; set; }
        public virtual Region Region { get; set; }

        public IList<Booking> Booking { get; set; }
    }
}
