using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class PaymentMethod : BaseAuditableEntity
    {
        public string PaymentMethodName { get; set; } = null!;

        //Relationship
        public IList<PaymentHistory> PaymentHistory { get; set; }
    }
}
