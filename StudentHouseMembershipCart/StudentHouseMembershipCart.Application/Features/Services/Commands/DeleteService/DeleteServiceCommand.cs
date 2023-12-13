using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.DeleteService
{
    public class DeleteServiceCommand : IRequest<SHMResponse>
    {
        public string ServiceId { get; set; } = null!;
    }
}