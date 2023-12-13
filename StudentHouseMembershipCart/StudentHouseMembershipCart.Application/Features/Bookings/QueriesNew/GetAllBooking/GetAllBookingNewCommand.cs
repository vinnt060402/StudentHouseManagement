using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBooking
{
    public class GetAllBookingNewCommand : IRequest<List<BookingDataNew>>
    {
    }
}