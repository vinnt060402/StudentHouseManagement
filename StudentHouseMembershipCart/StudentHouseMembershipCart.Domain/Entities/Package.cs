using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Package : BaseAuditableEntity 
    { 
        public string PackageName { get; set; } = null!;
        public string? PackageDescription { get; set; }
        #region Will be deleted
        public int WeekNumberBooking { get; set; }
        public int NumberOfPerWeekDoPackage { get; set; }
        public string? DayDoServiceInWeek { get; set; }
        #endregion
        public string? Image { get; set; }
        /// <summary>
        /// Tổng giá sau khi giảm
        /// </summary>
        public double? TotalPrice { get; set; }
        /// <summary>
        /// Phần trăm giảm giá
        /// </summary>
        public double? DiscountPercent { get; set; }
        /// <summary>
        /// Tổng giá gốc
        /// </summary>
        public double? TotalOriginalPrice { get; set; } 


        // relationShip
        
        public IList<BookingDetailOfService> BookingDetailOfService { get; private set; }
        public IList<BookingDetailOfPakcage> BookingDetailOfPakcage { get; private set; }
        public IList<PackageService> PackageService { get; private set; }

    }

}
