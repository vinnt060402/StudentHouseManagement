using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<SHMResponse>
    {
        public string? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryName { get; set; }
        public string? UpdateBy { get; set; }
    }
}