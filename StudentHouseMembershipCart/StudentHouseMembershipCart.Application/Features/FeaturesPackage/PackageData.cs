namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage
{
    public class PackageData
    {
        public Guid Id { get; set; }
        public string PackageName { get; set; }
        public int weekNumberBooking { get; set; }
        public int numberOfPerWeekDoPackage { get; set; }
        public string Image { get; set; }
        public Guid AdminId { get; set; }
        public DateTime? Created { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}
