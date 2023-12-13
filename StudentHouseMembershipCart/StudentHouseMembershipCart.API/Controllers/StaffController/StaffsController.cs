using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Staffs.Commands.CreateStaff;
using StudentHouseMembershipCart.Application.Features.Staffs.Commands.DeleteStaff;
using StudentHouseMembershipCart.Application.Features.Staffs.Commands.UpdateStaff;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetAllStaffByCategoryId;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff;

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
        [Route("staffs")]
        public async Task<List<StaffResponse>> GetAllStaff()
        {
            var response = await _mediator.Send(new GetListStaffQuery());
            return response;
        }
        [HttpGet]
        [Route("staffsbyId")]
        public async Task<ActionResult<StaffResponse>> GetStaffById([FromQuery] GetStaffQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet]
        [Route("serviceid")]
        public async Task<List<StaffResponse>> GetStaffByCategoryId(string serviceid)
        {
            var request = new GetAllStaffByCategoryIdQuery()
            {
                ServiceId = serviceid
            };
            return await _mediator.Send(request);
        }
        [HttpPost]
        [Route("staffs")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateStaff(CreateStaffRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPut]
        [Route("staffs")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdateStaff(UpdateStaffCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpDelete]
        [Route("staffs")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> DeleteStaff(DeleteStaffCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}