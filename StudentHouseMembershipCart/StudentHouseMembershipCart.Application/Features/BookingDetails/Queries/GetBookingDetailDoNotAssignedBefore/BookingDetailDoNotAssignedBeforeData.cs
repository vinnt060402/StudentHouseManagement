namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailDoNotAssignedBefore
{
    public class BookingDetailDoNotAssignedBeforeData
    {
        public string? BookingDetailName { get; set; }
        public Guid Id { get; set; }
        public double TotalPriceOfQuantity { get; set; }
        public bool IsRe_Newed { get; set; }
        public int RemainingTaskDuration { get; set; }
        public int QuantityOfPackageOrdered { get; set; }
        public string? BookingDetailStatus { get; set; }
        public Guid BookingId { get; set; }
        public Guid PackageId { get; set; }
        public DateTime Created { get; set; }
        public string? CreateBy { get; set; }
        public DateTime LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool IsDelete { get; set; }
    }
}