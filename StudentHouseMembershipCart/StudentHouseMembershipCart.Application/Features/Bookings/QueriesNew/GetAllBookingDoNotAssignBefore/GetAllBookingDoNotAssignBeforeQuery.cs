using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBookingDoNotAssignBefore
{
    public class GetAllBookingDoNotAssignBeforeQuery : IRequest<List<BookingDetailDoNotAssignBeforeData>>
    {
    }
}
