using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.UpdatePackageServiceCommand
{
    public class UpdatePackageServiceCommand : IRequest<SHMResponse>
    {
        public Guid PackageId { get; set; }
        public List<Guid> ListServiceId { get; set; } = null!;
        public int Quantity { get; set; }
    }
}