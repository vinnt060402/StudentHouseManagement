using MediatR;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById
{
    public class GetPakageByIdCommand : IRequest<PackageData>
    {
        public string PakageId { get; set; } = null!;
    }
}
