namespace StudentHouseMembershipCart.Application.Features.Services
{
    public class ServiceData
    {
        public Guid Id { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        /// <summary>
        /// Giá gốc
        /// </summary>
        public double? OriginalPrice { get; set; }
        /// <summary>
        /// 1. Khách hàng giao và nhận kết quả
        /// 2. Giao sản phẩm hoặc thực hiện dịch vụ tại nhà khách hàng
        /// </summary>
        public string? ServiceType { get; set; }
        /// <summary>
        /// Đại diện đơn vị
        /// </summary>
        public string? Unit { get; set; }
        public string? CategoryId { get; set; }
        public DateTime? Created { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}