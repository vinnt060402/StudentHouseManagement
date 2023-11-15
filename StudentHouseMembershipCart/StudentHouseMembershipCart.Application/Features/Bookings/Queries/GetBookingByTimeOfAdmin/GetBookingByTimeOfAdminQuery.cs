using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByTimeOfAdmin
{
    public class GetBookingByTimeOfAdminQuery : IRequest<BookingDataForAdmin>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}