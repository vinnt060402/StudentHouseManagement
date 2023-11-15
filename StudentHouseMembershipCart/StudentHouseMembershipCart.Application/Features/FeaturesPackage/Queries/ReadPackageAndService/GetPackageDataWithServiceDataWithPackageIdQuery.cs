using MediatR;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadPackageAndService
{
    public class GetPackageDataWithServiceDataWithPackageIdQuery : IRequest<PackageDataAndServiceData>
    {
        public string PackageId { get; set; } = null!;
    }
}