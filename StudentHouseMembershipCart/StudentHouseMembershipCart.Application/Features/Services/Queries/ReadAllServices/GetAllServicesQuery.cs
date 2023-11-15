using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Services.Queries.ReadAllServices
{
    public class GetAllServicesQuery : IRequest<List<ServiceData>>
    {
    }
}