using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFP
{
    public class GetAllPackageQueryHandler : IRequestHandler<GetAllPackageQuery, List<PackageData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAllPackageQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PackageData>> Handle(GetAllPackageQuery request, CancellationToken cancellationToken)
        {
            var listPackage = await _dbContext.Package.ToListAsync();
            if (!listPackage.Any())
            {
                throw new NotFoundException("Have no package!");
            }
            var listResult = new List<PackageData>();
            foreach(var item in listPackage)
            {
                var result = _mapper.Map<PackageData>(item);
                listResult.Add(result);
            }
            return listResult;
        }
    }
}
