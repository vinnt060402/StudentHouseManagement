using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.CreateBookingDetail;
using StudentHouseMembershipCart.Application.Features.BookingDetailStaffs.Commands.CreateBookingDetailStaff;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;

namespace StudentHouseMembershipCart.API.Controllers.BookingDetailStaffs
{
    [Route("api/v1/bookingdetailstaff")]
    [ApiController]
    public class BookingDetailStaffController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingDetailStaffController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateBookingDetailStaff(CreateBookingDetailStaffCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
