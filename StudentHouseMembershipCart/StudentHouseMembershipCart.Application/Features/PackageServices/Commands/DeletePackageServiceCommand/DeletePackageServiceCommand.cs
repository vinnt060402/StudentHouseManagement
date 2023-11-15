using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Commands.DeletePackageServiceCommand
{
    public class DeletePackageServiceCommand : IRequest<SHMResponse>
    {
        public string PackageId { get; set; } = null!;
    }
}