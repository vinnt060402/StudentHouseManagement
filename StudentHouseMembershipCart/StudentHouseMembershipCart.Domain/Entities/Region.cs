using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Region : BaseAuditableEntity
    {
        public string RegionName { get; set; } = null!;

        //Relationship
        public IList<Apartment> Apartments { get; private set; }
    }
}
