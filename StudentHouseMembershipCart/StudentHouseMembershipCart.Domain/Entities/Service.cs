using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Service : BaseAuditableEntity 
    { 
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public double? Price { get; set; } 
        public string? Image { get; set;}

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        // relationShip
        public virtual Category Category { get; set; }
        public IList<PackageService> PackageService { get; private set; }
    }

}
