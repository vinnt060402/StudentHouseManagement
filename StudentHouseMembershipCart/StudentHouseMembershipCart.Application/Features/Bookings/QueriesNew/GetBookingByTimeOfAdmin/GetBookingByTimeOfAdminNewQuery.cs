using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByTimeOfAdmin
{
    public class GetBookingByTimeOfAdminNewQuery : IRequest<BookingDataForAdminNew>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}