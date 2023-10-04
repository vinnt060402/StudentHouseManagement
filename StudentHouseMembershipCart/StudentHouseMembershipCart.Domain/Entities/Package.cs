using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Package : BaseAuditableEntity 
    { 
        public string PackageName { get; set; } = null!;
        public int weekNumberBooking { get; set; }
        public int numberOfPerWeekDoPackage { get; set; }
        public string? Image { get; set; }
        [ForeignKey("Admin")]
        public Guid AdminId { get; set; }

        // relationShip
        public virtual Admin Admin { get; set; }
        public IList<BookingDetail> BookingDetail { get; private set; }
        public IList<PackageService> PackageService { get; private set; }

    }

}
