using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreateCategoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryExisted = await _dbContext.Category.Where(x => x.CategoryName == request.CategoryName && !x.IsDelete).FirstOrDefaultAsync();
            if (categoryExisted != null)
            {
                throw new BadRequestException("The category already exists!");
            }
            var category = new Category
            {
                CategoryName = request.CategoryName,
                Image = request.ImageUrl,
                CreateBy = request.CreateBy,
                Created = DateTime.Now,
                IsDelete = false
            };
            _dbContext.Category.Add(category);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
    }
}