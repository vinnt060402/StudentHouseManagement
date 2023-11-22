using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP
{
    public class CreatePakageCommand : IRequest<SHMResponse>
    {
        public string PackageName { get; set; } = null!;
        public string? PackageDescription { get; set; }

        /// <summary>
        /// Phần trăm giảm giá
        /// </summary>
        public double? DiscountPercent { get; set; }
        public string? ImageUrl { get; set; }
        public List<ServiceWithQuantity> ListServiceWithQuantity { get; set; } = null!;
    }
    public class ServiceWithQuantity
    {
        public Guid ServiceId { get; set; }
        public int Quantity { get; set; }    
    }
}