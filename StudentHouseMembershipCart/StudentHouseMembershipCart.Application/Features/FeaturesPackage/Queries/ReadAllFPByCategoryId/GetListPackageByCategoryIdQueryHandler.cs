using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFPByCategoryId
{
    public class GetListPackageByCategoryIdQueryHandler : IRequestHandler<GetListPackageByCategoryIdQuery, List<PackageData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetListPackageByCategoryIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<PackageData>> Handle(GetListPackageByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var packageByCategoryId = await (from package in _dbContext.Package
                                             join packageService in _dbContext.PackageService
                                             on package.Id
                                             equals packageService.PackageId

                                             join service in _dbContext.Service
                                             on packageService.ServiceId
                                             equals service.Id

                                             join category in _dbContext.Category
                                             on service.CategoryId
                                             equals category.Id
                                             where category.Id == request.CategoryId

                                             select package
                                       ).ToListAsync();
            if (!packageByCategoryId.Any())
            {
                throw new NotFoundException("Does not have Package have Category like that!!");
            }
            var listResult = new List<PackageData>();
            foreach (var item in packageByCategoryId)
            {
                var getPakcage = new GetPackageByIdCommand
                {
                    PakageId = item.Id.ToString()
                };
                var getPackageResponse = await _mediator.Send(getPakcage);

                listResult.Add(getPackageResponse);
            }
            return listResult;
        }
    }
}