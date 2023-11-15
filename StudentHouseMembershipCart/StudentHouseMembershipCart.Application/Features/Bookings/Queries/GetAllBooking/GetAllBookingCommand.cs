using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking
{
    public class GetAllBookingCommand : IRequest<List<BookingData>>
    {
    }
}