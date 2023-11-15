using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadCategoryById
{
    public class GetCategoryByIdCommandHandler : IRequestHandler<GetCategoryByIdCommand, CategoryData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetCategoryByIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CategoryData> Handle(GetCategoryByIdCommand request, CancellationToken cancellationToken)
        {
            var category = await _dbContext.Category.Where(x => x.Id == Guid.Parse(request.CategoriesId)).SingleOrDefaultAsync();
            if (category == null)
            {
                throw new NotFoundException("Have no service!");
            }
            var response = _mapper.Map<CategoryData>(category);
            return response;
        }
    }
}