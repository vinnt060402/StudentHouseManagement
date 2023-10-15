using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.CreateCategory;

namespace StudentHouseMembershipCart.API.Controllers.Bookings
{
    [Route("api/v1/bookings")]
    [ApiController]
    public class BookingController
    {
        private readonly IMediator _mediator;

        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("bookings")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateBooking(CreateBookingCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
