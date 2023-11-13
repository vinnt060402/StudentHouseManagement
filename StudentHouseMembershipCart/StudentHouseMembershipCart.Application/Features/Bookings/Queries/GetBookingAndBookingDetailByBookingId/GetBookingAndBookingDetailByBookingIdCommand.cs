using MediatR;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByTimeOfAdmin;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingAndBookingDetailByBookingId
{
    public class GetBookingAndBookingDetailByBookingIdCommand : IRequest<BookingData>
    {
        public Guid BookingId { get; set; }
    }
}
