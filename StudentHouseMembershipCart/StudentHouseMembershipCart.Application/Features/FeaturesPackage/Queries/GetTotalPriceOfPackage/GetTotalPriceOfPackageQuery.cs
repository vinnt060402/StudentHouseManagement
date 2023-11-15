using MediatR;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.GetTotalPriceOfPackage
{
    public class GetTotalPriceOfPackageQuery : IRequest<double>
    {
        public string PackageId = null!;
        public int WeekNumberBooking { get; set; }
        public int NumberOfPerWeekDoPackage { get; set; }
    }
}