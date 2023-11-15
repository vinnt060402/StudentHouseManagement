using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Commands.UpdateApartment
{
    public class UpdateApartmentCommand : IRequest<Unit>
    {
        public Guid ApartmentId { get; set; }

        public string AddressOfApartment { get; set; }
        //student
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string AddressOfStudent { get; set; }
        //region
        public string RegionName { get; set; }



    }
}