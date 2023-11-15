namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries
{
    public class PaymentHistoryData
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }
        public double Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool IsDelete { get; set; }
    }
}