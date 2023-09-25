using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Category : BaseAuditableEntity 
    {
        [Key]
        public string CategoryId { get; set; } = null!;
        public string CategoryName { get; set; }

        // relationShip
        public IList<Service> Service { get; private set; }
    }

}
