using MediatR;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFPByCategoryId
{
    public class GetListPackageByCategoryIdQuery : IRequest<List<PackageData>>
    {
        public Guid CategoryId { get; set; }
    }
}