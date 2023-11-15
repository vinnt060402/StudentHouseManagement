using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<SHMResponse>
    {
        public string? CategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public string? CreateBy { get; set; }
    }
}