using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;

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

        [HttpPost]
        public async Task<SHMResponse> CreateNewAttendData(CreateAttendenceReportCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}