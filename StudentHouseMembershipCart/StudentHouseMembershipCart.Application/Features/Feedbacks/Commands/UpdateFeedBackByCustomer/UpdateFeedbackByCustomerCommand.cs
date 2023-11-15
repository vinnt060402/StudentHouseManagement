using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackByCustomer
{
    public class UpdateFeedbackByCustomerCommand : IRequest<SHMResponse>
    {
        public Guid FeedBackId { get; set; }
        public string? FeedBackName { get; set; }
        public string? FeedBackDescription { get; set; }
        public string? FeedBackImageUrl { get; set; }
        public string FeedBackRating { get; set; }
    }
}