using StudentHouseMembershipCart.Application.Features.Services;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadPackageAndService
{
    public class PackageDataAndServiceData
    {
        public PackageData? PackageData { get; set; }
        public List<ServiceData>? ListServiceData { get; set; }
    }
}