using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.CreatePackageServiceCommand
{
    public class CreatePackageServiceCommand : IRequest<SHMResponse>
    {
        public Guid PackageId { get; set; }
        public List<Guid> ListSerivceId { get; set; } = null!;
        public int Quantity { get; set; }
    }
}