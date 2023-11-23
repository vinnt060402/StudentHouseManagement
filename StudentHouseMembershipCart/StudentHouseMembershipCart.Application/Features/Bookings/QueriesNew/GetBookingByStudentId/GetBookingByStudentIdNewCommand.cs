using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByStudentId
{
    public class GetBookingByStudentIdNewCommand : IRequest<List<BookingDataNew>>
    {
        public Guid StudentId { get; set; }
    }
}
