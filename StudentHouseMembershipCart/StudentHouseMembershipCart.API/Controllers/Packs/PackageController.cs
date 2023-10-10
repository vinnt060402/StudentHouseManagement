using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadCategoryById;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.DeleteFP;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFP;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById;
using Microsoft.AspNetCore.Authorization;

namespace StudentHouseMembershipCart.API.Controllers.Packs
{
    [Route("api/v1/packages")]
    [ApiController]
    public class PackageController
    {
        private readonly IMediator _mediator;

        public PackageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("packages")]
        public async Task<List<PackageData>> GetAllPackages()
        {
            return await _mediator.Send(new GetAllPackageQuery());
        }
        [HttpGet]
        [Route("packagesbyid")]
        public async Task<PackageData> GetPackageById([FromQuery] GetPakageByIdCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost]
        [Route("packages")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreatePackage(CreatePakageCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPatch]
        [Route("packages")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdatePackage(UpdatePackageCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpDelete]
        [Route("packages")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> DeletePackage(DeletePackageCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
