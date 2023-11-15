using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetFeedBackByFBID
{
    public class GetFeedBackByFBIDQuery : IRequest<FeedBackData>
    {
        public string FeedBackId { get; set; } = null!;
    }
}