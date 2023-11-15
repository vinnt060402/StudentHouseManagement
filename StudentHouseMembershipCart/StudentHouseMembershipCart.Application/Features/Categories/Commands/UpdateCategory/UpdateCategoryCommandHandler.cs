using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdateCategoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
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
            category.CategoryName = request.CategoryName ?? category.CategoryName;
            category.LastModified = DateTime.Now;
            category.Image = request.ImageUrl;
            category.LastModifiedBy = request.UpdateBy ?? category.LastModifiedBy;
            _dbContext.Category.Update(category);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}