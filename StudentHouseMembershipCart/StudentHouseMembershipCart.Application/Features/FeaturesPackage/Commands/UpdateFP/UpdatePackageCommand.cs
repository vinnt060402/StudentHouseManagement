using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP
{
    public class UpdatePackageCommand : IRequest<SHMResponse>
    {
        public string? PackageId { get; set; } = null!;
        public string? PackageName { get; set; } = null!;
        public string? UpdateBy { get; set; } = null!;
    }
}
