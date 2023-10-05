using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Staffs.Commands.CreateStaff;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Application.Features.Students.Commands.CreateStudent;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.API.Controllers.StaffController
{
    [Route("api/v1/staffs")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-staff")]
        public async Task<List<StaffResponse>> GetAllStaff()
        {
            var response = await _mediator.Send(new GetListStaffQuery());
            return response;
        }
        [HttpPost]
        [Route("register-staff")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateStaff([FromQuery] CreateStaffRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
