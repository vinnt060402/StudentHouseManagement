using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadAllCategories
{
    public class GetAllCatetoryQueryHandler : IRequestHandler<GetAllCatetoryQuery, List<CategoryData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAllCatetoryQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<CategoryData>> Handle(GetAllCatetoryQuery request, CancellationToken cancellationToken)
        {
            var listCategories = await _dbContext.Category.ToListAsync();
            if (!listCategories.Any())
            {
                throw new NotFoundException("Have no category before!");
            }
            var listResponse = new List<CategoryData>();
            foreach (var category in listCategories)
            {
                var response = _mapper.Map<CategoryData>(category);
                listResponse.Add(response);
            }
            return listResponse;
        }
    }
}