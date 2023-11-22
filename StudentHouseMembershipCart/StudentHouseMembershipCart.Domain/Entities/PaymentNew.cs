using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class PaymentNew : BaseAuditableEntity
    {
        [Key]
        public string PaymentNewId { get; set; } = string.Empty;
        public string PaymentContent { get; set; } = string.Empty;
        public string PaymentCurrency { get; set; } = string.Empty;
        public string PaymentRefId { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; } = 20000;
        public DateTime? PaymentDate { get; set; } = DateTime.Now;
        public DateTime? ExpireDate { get; set; }
        /// <summary>
        /// Chữ kí sẽ được cập nhật nếu được đăng kí thành công
        /// </summary>
        public string? Signature { get; set; }
        public string? PaymentDestinationId { get; set; } = string.Empty;
        public decimal? PaidAmount { get; set; }
        /// <summary>
        /// 0. Chưa được thanh toán
        /// 1. Đã được thanh toán
        /// </summary>
        public string? PaymentStatus { get; set; } = string.Empty;
        // relationShip
        public IList<PaymentTransaction> PaymentTransactions { get; set; }
        //public virtual Booking Booking { get; set; }
    }
}
