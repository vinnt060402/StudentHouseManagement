using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.CreatePackageServiceCommand
{
    public class CreatePackageServiceCommand : IRequest<SHMResponse>
    {
        public Guid PackageId { get; set; }
        public List<Guid> ListServiceId { get; set; } = null!;
        public string? CreateBy { get; set; }
    }
}