using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest<SHMResponse>
    {
        public string CategoryId { get; set; } = null!;
        public string? DeleteBy { get; set; }
    }
}