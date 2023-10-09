using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Package : BaseAuditableEntity 
    { 
        public string PackageName { get; set; } = null!;
        public int WeekNumberBooking { get; set; }
        public int NumberOfPerWeekDoPackage { get; set; }
        public string? Image { get; set; }
        public double? TotalPrice { get; set; }
        


        // relationShip
        
        public IList<BookingDetail> BookingDetail { get; private set; }
        public IList<PackageService> PackageService { get; private set; }

    }

}
