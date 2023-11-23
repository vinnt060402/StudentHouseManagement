using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP
{
    public class UpdatePackageCommand : IRequest<SHMResponse>
    {
        public string PackageId { get; set; } = null!;

        /// <summary>
        /// Phần trăm giảm giá
        /// </summary>
        public double? DiscountPercent { get; set; }
        public List<Guid> ListServiceId { get; set; } = null!;
        public int Quantity { get; set; }
        public string? PackageName { get; set; } = null!;
        public string? PackageDescription { get; set; }
        public string? ImageUrl { get; set; }
    }
}