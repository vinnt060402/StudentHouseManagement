using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Service : BaseAuditableEntity 
    { 
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        /// <summary>
        /// Giá Bán ra
        /// </summary>
        public double? Price { get; set; } 
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
        public string? Image { get; set;}

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        // relationShip
        public virtual Category Category { get; set; }
        public IList<PackageService> PackageService { get; private set; }
    }

}
