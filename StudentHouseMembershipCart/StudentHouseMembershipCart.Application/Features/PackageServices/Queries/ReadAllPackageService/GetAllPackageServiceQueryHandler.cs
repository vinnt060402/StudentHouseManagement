using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage;

namespace StudentHouseMembershipCart.Application.Features.PackageServices.Queries.ReadAllPackageService
{
    public class GetAllPackageServiceQueryHandler : IRequestHandler<GetAllPackageServiceQuery, List<PackageServiceData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAllPackageServiceQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PackageServiceData>> Handle(GetAllPackageServiceQuery request, CancellationToken cancellationToken)
        {
            var listPackage = await _dbContext.PackageService.ToListAsync();
            if (!listPackage.Any())
            {
                throw new NotFoundException("Have no package!");
            }
            var listResult = new List<PackageServiceData>();
            foreach (var item in listPackage)
            {
                var result = _mapper.Map<PackageServiceData>(item);
                listResult.Add(result);
            }
            return listResult;
        }
    }
}