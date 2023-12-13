using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailByStaffId;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.CreateReportWork;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.UpdateReportWorkByStaff;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Queries;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByBookingDetailId;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByStaffIdAndServiceId;

namespace StudentHouseMembershipCart.API.Controllers.ReportWorks
{
    [Route("api/v1/reportworks")]
    [ApiController]
    public class ReportWorkController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportWorkController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdateReportWorkedByStaff(UpdateReportWorkByStaffCommand request)
        {
            return await _mediator.Send(request);
        }/*
        [HttpGet]
        [Route("bookingdetails/{id}")]
        public async Task<List<ReportWorkData>> GetBookingDetailByStaffId(string id)
        {
            return await _mediator.Send(new GetReportWorkByBookingDetailIdQuery()
            {
                BookingDetailId = id
            });
        }*/
        [HttpGet]
        [Route("get-report-work-by-staffid-and-service-id")]
        public async Task<List<ReportWorkData>> GetRWByStaffAndService([FromQuery] GetReportWorkByStaffIdAndServiceIdQuery request)
        {
            return await _mediator.Send(request);
        }
    }
}