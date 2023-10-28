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
        public string? PackageDescription { get; set; }
        public int WeekNumberBooking { get; set; }
        public int NumberOfPerWeekDoPackage { get; set; }
        public string? ImageUrl { get; set; }
        public string? UpdateBy { get; set; } = null!;
    }
}
