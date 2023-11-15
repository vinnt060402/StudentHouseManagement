using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.CreateCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.DeleteCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.UpdateCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadAllCategories;
using StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadCategoryById;

namespace StudentHouseMembershipCart.API.Controllers.Categories
{
    [Route("api/v1/categories")]
    [ApiController]
    public class CategoriesController
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("categories")]
        public async Task<List<CategoryData>> GetAllCategory()
        {
            return await _mediator.Send(new GetAllCatetoryQuery());
        }
        [HttpGet]
        [Route("categoriesbyid")]
        public async Task<CategoryData> GetServiceById([FromQuery] GetCategoryByIdCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost]
        [Route("categories")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateCategory(CreateCategoryCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPut]
        [Route("categories")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdateCategory(UpdateCategoryCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpDelete]
        [Route("categories")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> DeleteCategory(DeleteCategoryCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}