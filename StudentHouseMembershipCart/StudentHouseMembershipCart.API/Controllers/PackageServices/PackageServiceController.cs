using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.CreateCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.DeleteCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.UpdateCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadAllCategories;
using StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadCategoryById;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.PackageServices;
using StudentHouseMembershipCart.Application.Features.PackageServices.Queries.ReadAllPackageService;
using StudentHouseMembershipCart.Application.Features.PackageServices.Commands.CreatePackageServiceCommand;
using StudentHouseMembershipCart.Application.Features.PackageServices.Commands.UpdatePackageServiceCommand;

namespace StudentHouseMembershipCart.API.Controllers.PackageServices
{
    [Route("api/v1/packageservices")]
    [ApiController]
    public class PackageServiceController
    {
        private readonly IMediator _mediator;

        public PackageServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("packageservices")]
        public async Task<List<PackageServiceData>> GetAllPackageService()
        {
            return await _mediator.Send(new GetAllPackageServiceQuery());
        }
        [HttpPost]
        [Route("packageservices")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreatePakageService(CreatePackageServiceCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPut]
        [Route("packageservices")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdatePackageService(UpdatePackageServiceCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpDelete]
        [Route("packageservices")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> DeletePackageService(DeleteCategoryCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}