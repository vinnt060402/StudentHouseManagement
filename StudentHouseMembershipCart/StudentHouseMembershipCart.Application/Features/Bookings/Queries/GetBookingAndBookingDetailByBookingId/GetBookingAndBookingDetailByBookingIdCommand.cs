using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingAndBookingDetailByBookingId
{
    public class GetBookingAndBookingDetailByBookingIdCommand : IRequest<BookingData>
    {
        public Guid BookingId { get; set; }
    }
}