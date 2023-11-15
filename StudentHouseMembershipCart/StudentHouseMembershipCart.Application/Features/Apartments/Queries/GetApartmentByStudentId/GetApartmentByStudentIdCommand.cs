using MediatR;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByStudentId
{
    public class GetApartmentByStudentIdCommand : IRequest<List<ApartmentResponse>>
    {
        public Guid StudentId { get; set; }
    }
}