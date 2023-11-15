using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByApartmentId
{
    public class GetApartmentByApartmentIdQuery : IRequest<ApartmentDto>
    {
        public Guid ApartmentId { get; set; }
    }
}