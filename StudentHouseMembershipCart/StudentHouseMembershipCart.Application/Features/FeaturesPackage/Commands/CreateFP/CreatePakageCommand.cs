using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP
{
    public class CreatePakageCommand : IRequest<SHMResponse>
    {
        public string PackageName { get; set; } = null!;
        public int weekNumberBooking { get; set; }
        public int numberOfPerWeekDoPackage { get; set; }
        public string? ImageUrl { get; set; }
        public Guid AdminId { get; set; }
        public string? CreateBy { get; set; }
    }
}
