using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP
{
    public class UpdatePackageCommand : IRequest<SHMResponse>
    {
        public string PackageId { get; set; } = null!;
        public List<Guid> ListServiceId { get; set; } = null!;
        public string? PackageName { get; set; } = null!;
        public string? DayDoServiceInWeek { get; set; }
        public int weekNumberBooking { get; set; }
        public int numberOfPerWeekDoPackage { get; set; }
        public string? ImageUrl { get; set; }
        public string? UpdateBy { get; set; } = null!;
    }
}
