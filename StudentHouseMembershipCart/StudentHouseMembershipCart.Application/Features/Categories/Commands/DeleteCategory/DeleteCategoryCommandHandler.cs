using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public DeleteCategoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _dbContext.Category.Where(x => x.Id == Guid.Parse(request.CategoryId)).SingleOrDefaultAsync();
            if (category == null)
            {
                throw new NotFoundException("The category have not existed!");
            }
            if (category.IsDelete)
            {
                throw new BadRequestException("The category have been deleted!");
            }
            category.IsDelete = true;
            category.LastModified = DateTime.Now;
            category.LastModifiedBy = request.DeleteBy;
            _dbContext.Category.Update(category);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}