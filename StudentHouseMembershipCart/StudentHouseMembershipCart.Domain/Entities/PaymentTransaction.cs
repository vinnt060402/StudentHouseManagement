using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class PaymentTransaction : BaseAuditableEntity
    {
        public string PaymentTransactionId { get; set; } = string.Empty;
        //Một thuộc tính string chứa thông điệp hoặc tin nhắn liên quan đến giao dịch.
        public string? TranMessage { get; set; } = string.Empty;
        //Một thuộc tính string chứa dữ liệu hoặc thông tin chi tiết liên quan đến giao dịch.
        //Payload thường là dữ liệu được chuyển đi cùng với một yêu cầu hoặc phản hồi.
        public string? TranPayload { get; set; } = string.Empty;
        //Một thuộc tính string đại diện cho trạng thái của giao dịch,
        //có thể là "Thành công", "Đang xử lý", "Thất bại" hoặc các giá trị tương tự.
        /// <summary>
        /// 0. Chưa thành công
        /// 1. Thành công
        /// </summary>
        public string? TranStatus { get; set; } = string.Empty;
        public decimal? TranAmount { get; set; }
        //Một thuộc tính DateTime chứa thông tin về thời điểm thực hiện giao dịch.
        public string? TranDate { get; set; }
        [ForeignKey("PaymentNew")]
        public string? PaymentNewId { get; set; } = string.Empty;
        public string? TranRefId { get; set; } = string.Empty;

        //Relationship
        public virtual PaymentNew PaymentNew { get; set; }
    }
}
