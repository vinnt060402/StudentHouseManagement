using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetListFeedBackByBookingDetailId
{
    public class GetListFeedBackByBookingDetailIdQuery : IRequest<List<FeedBackData>>
    {
        public string BookingDetailId { get; set; } = null!;
    }
}