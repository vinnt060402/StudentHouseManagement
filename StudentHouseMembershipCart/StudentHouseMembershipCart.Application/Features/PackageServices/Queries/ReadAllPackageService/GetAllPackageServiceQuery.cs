using MediatR;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Queries.ReadAllPackageService
{
    public class GetAllPackageServiceQuery : IRequest<List<PackageServiceData>>
    {
    }
}