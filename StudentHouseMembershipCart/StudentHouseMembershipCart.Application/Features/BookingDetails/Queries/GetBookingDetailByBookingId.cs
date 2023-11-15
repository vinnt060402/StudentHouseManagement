using MediatR;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries
{
    public class GetBookingDetailByBookingId : IRequest<List<BookingDetailData>>
    {
        public Guid BookingId { get; set; }
    }
}