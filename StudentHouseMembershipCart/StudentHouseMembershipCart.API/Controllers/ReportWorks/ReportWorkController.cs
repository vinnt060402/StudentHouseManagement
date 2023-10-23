using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.CreateReportWork;

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
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateReportWork(CreateReportWorkCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
