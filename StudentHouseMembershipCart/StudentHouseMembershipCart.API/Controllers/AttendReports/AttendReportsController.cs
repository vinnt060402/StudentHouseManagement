using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking;
using StudentHouseMembershipCart.Application.Features.Bookings;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByBookingDetailId;
using StudentHouseMembershipCart.Application.Features.AttendenceReports;

namespace StudentHouseMembershipCart.API.Controllers.AttendReports
{
    [Route("api/v1/attendreport")]
    [ApiController]
    public class AttendReportsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AttendReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("bookingdetailid")]
        public async Task<AttendReportDataResponse> GetAttendReportByBookingDetailId([FromQuery]GetAttendReportByBookingDetailIdCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
