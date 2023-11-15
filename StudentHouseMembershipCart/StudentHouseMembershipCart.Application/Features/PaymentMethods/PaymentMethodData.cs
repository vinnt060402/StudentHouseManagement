namespace StudentHouseMembershipCart.Application.Features.PaymentMethods
{
    public class PaymentMethodData
    {
        public string Id { get; set; } = null!;
        public string PaymentMethodName { get; set; } = null!;
        public string? CreateBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool IsDelete { get; set; }

    }
}