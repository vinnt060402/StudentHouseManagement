using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadCategoryById
{
    public class GetCategoryByIdCommand : IRequest<CategoryData>
    {
        public string CategoriesId { get; set; } = null!;
    }
}