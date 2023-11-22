using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.DeleteFP
{
    public class DeletePackageCommand : IRequest<SHMResponse>
    {
        public string PackageId { get; set; } = null!;
    }
}