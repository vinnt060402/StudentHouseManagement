using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Commands.CreateApartment
{
    public class CreateApartmentCommand : IRequest<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid RegionId { get; set; }

        /* public string NameApartment { get; set; }*/
        public string AddressOfApartment { get; set; }
    }
}