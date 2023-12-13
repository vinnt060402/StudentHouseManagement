using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Services;
using StudentHouseMembershipCart.Application.Features.Services.Commands.CreateService;
using StudentHouseMembershipCart.Application.Features.Services.Commands.DeleteService;
using StudentHouseMembershipCart.Application.Features.Services.Commands.UpdateService;
using StudentHouseMembershipCart.Application.Features.Services.Queries.ReadAllServices;
using StudentHouseMembershipCart.Application.Features.Services.Queries.ReadServiceById;

namespace StudentHouseMembershipCart.API.Controllers.Services
{
    [Route("api/v1/services")]
    [ApiController]
    public class ServicesController
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        //[Route("services")]
        public async Task<List<ServiceData>> GetAllService()
        {
            return await _mediator.Send(new GetAllServicesQuery());
        }
        [HttpGet]
        [Route("{serviceid}")]
        public async Task<ServiceData> GetServiceById(string serviceid)
        {
            var request = new GetServiceByIdQuery()
            {
                SerivceId = serviceid
            };
            return await _mediator.Send(request);
        }
        [HttpPost]
   //     [Route("services")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateService(CreateServiceCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPut]
        //[Route("services")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdateService(UpdateServiceCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpDelete]
        //[Route("services")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> DeleteService(DeleteServiceCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}