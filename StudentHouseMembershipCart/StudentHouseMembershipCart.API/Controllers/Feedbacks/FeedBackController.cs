using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackByCustomer;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByBookingDetailId;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Queries;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Queries;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetFeedBackByFBID;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetListFeedBackByBookingDetailId;

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
        [HttpGet]
        [Route("{id}")]
        public async Task<FeedBackData> GetFeedbackById(string id)
        {
            return await _mediator.Send(new GetFeedBackByFBIDQuery()
            {
                FeedBackId = id
            });
        }
        [HttpGet]
        [Route("bookingdetail/{id}")]
        public async Task<List<FeedBackData>> GetFeedbackByBookingDetailId(string id)
        {
            return await _mediator.Send(new GetListFeedBackByBookingDetailIdQuery()
            {
                BookingDetailId = id
            });
        }
    }
}