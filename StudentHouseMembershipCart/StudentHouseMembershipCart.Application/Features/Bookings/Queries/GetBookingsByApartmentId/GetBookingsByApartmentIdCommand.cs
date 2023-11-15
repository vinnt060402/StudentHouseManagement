using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingsByApartmentId
{
    public class GetBookingsByApartmentIdCommand : IRequest<List<BookingData>>
    {
        public string ApartmentId { get; set; } = null!;
    }
}