using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Category : BaseAuditableEntity 
    { 
        public string CategoryName { get; set; }

        // relationShip
        public IList<Service> Service { get; private set; }
    }

}
