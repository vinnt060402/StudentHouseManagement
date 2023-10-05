using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.Regions.Queries.GetAllRegion;
using StudentHouseMembershipCart.Application.Features.Regions;
using StudentHouseMembershipCart.Application.Features.Regions.Commands.CreateRegion;
using StudentHouseMembershipCart.Application.Features.Apartments.Commands.CreateApartment;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment;
using StudentHouseMembershipCart.Application.Features.Apartments;
using StudentHouseMembershipCart.Application.Features.Students.Commands.DeleteStudent;
using StudentHouseMembershipCart.Application.Features.Apartments.Commands.DeleteApartment;
using StudentHouseMembershipCart.Application.Features.Students.Commands.UpdateStudent;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Application.Features.Apartments.Commands.UpdateApartment;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentHouseMembershipCart.API.Controllers.Apartments
{
    [Route("api/v1/apartment")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApartmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-apartment")]
        public async Task<List<ApartmentDto>> GetAllAparment()
        {
            var response = await _mediator.Send(new GetListApartmentQuery());
            return response;
        }

        [HttpPost]
        [Route("register-apartment")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateApartment([FromQuery] CreateApartmentCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAllAparment), new { id = response });
            /*return Ok(response);*/
        }

        [HttpDelete]
        [Route("delete-apartment-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete([FromQuery] DeleteApartmentCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("update-apartment-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ApartmentDto>> UpdateApartment(UpdateApartmentCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok("Update apartment Successfully");
        }
    }
}
