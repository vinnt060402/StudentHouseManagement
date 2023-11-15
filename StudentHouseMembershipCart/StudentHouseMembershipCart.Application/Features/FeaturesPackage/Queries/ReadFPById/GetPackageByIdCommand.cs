using MediatR;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById
{
    public class GetPackageByIdCommand : IRequest<PackageData>
    {
        public string PakageId { get; set; } = null!;
    }
}