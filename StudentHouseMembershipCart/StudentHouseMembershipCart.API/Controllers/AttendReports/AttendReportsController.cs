using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByServiceId;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBookingDoNotAssignBefore;

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
        [HttpGet]
        [Route("get-attendreport-by-student-id-and-service-id")]
        public async Task<List<NewAttendReportByService>> GetAllBookingDetailDoNotAssignBefore([FromQuery]GetAttendReportByServiceIdQuery request)
        {
            return await _mediator.Send(request);
        }
    }
}