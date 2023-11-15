using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByStudentId
{
    public class GetBookingByStudentIdCommand : IRequest<List<BookingData>>
    {
        public Guid StudentId { get; set; }
    }
}