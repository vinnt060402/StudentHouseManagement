using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackByCustomer;

namespace StudentHouseMembershipCart.API.Controllers.Feedbacks
{
    [Route("api/v1/feedbacks")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeedBackController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut]
        public async Task<SHMResponse> UpdateFeedBackByCustomer(UpdateFeedbackByCustomerCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
