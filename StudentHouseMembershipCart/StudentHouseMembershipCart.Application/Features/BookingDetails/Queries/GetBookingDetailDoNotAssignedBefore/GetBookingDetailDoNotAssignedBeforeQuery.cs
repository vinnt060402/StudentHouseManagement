using MediatR;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailDoNotAssignedBefore
{
    public class GetBookingDetailDoNotAssignedBeforeQuery : IRequest<List<BookingDetailDoNotAssignedBeforeData>>
    {
    }
}