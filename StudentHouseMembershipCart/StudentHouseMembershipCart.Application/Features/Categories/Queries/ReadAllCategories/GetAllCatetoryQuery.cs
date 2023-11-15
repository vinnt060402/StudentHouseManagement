using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadAllCategories
{
    public class GetAllCatetoryQuery : IRequest<List<CategoryData>>
    {
    }
}