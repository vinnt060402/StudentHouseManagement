namespace StudentHouseMembershipCart.Application.Features.PackageServices
{
    public class PackageServiceData
    {
        public Guid Id { get; set; }
        public Guid PackageId { get; set; }
        public Guid ServiceId { get; set; }
        public int? QuantityOfService { get; set; }
        public DateTime? Created { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}