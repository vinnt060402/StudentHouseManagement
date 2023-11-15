using MediatR;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFP
{
    public class GetAllPackageQuery : IRequest<List<PackageData>>
    {
    }
}