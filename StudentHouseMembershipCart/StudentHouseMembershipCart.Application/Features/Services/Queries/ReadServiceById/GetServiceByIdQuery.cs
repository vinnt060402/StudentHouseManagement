using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Services.Queries.ReadServiceById
{
    public class GetServiceByIdQuery : IRequest<ServiceData>
    {
        public string SerivceId { get; set; } = null!;
    }
}