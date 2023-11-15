using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment
{
    public class GetListApartmentQuery : IRequest<List<ApartmentResponse>>
    {
    }
}