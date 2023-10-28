using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Category : BaseAuditableEntity 
    {
        public string CategoryName { get; set; } = null!;
        public string? Image { get; set; }

        // relationShip
        public IList<Service> Service { get; private set; }
        public IList<StaffCategory> StaffCategories { get; set; }

    }

}
