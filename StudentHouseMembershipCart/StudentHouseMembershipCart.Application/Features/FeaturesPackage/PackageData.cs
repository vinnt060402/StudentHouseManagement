namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage
{
    public class PackageData
    {
        public Guid Id { get; set; }
        public string PackageName { get; set; }
        public int WeekNumberBooking { get; set; }
        public int NumberOfPerWeekDoPackage { get; set; }
        public List<string>? DayDoInWeek { get; set; }
        public string? PackageDescription { get; set; }
        public string Image { get; set; }
        public double TotalPrice { get; set; }
        public DateTime? Created { get; set; }
        public int PackageItem { get; set; } = 1;
        public string? CreateBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
