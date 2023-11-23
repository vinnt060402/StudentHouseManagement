using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.UpdateService
{
    public class UpdateServiceCommand : IRequest<SHMResponse>
    {
        public string ServiceId { get; set; } = null!;
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }

        /// <summary>
        /// Giá Gốc
        /// </summary>
        public double OriginalPrice { get; set; }
        /// <summary>
        /// Đại diện đơn vị KG hoặc Lượt
        /// </summary>
        public string? Unit { get; set; }
        /// <summary>
        /// Phần trăm giảm giá
        /// </summary>
        public double DiscountPercent { get; set; }
        public string ImageURL { get; set; } = null!;
        public string? CategoryId { get; set; }
    }
}