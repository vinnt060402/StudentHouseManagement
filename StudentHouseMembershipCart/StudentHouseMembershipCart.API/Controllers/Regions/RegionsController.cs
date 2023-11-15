using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.Regions;
using StudentHouseMembershipCart.Application.Features.Regions.Commands.CreateRegion;
using StudentHouseMembershipCart.Application.Features.Regions.Queries.GetAllRegion;
using StudentHouseMembershipCart.Application.Features.Regions.Queries.GetRegionById;
using StudentHouseMembershipCart.Application.Features.Students;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentHouseMembershipCart.API.Controllers.Regions
{
    [Route("api/v1/region")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-region")]
        public async Task<List<RegionDto>> GetAllRegion()
        {
            var response = await _mediator.Send(new GetListRegionQuery());
            return response;
        }

        [HttpPost]
        [Route("register-region")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateRegion([FromQuery] CreateRegionCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAllRegion), new { id = response });
        }

        [HttpGet]
        [Route("get-region-by-id")]
        public async Task<ActionResult<StudentDto>> GetRegionById([FromQuery] GetRegionByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }


    }
}