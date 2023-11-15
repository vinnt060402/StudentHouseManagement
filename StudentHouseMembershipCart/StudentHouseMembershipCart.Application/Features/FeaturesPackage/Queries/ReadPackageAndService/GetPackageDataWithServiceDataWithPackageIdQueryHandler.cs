using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById;
using StudentHouseMembershipCart.Application.Features.Services;
using StudentHouseMembershipCart.Application.Features.Services.Queries.ReadServiceById;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadPackageAndService
{
    internal class GetPackageDataWithServiceDataWithPackageIdQueryHandler : IRequestHandler<GetPackageDataWithServiceDataWithPackageIdQuery, PackageDataAndServiceData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetPackageDataWithServiceDataWithPackageIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<PackageDataAndServiceData> Handle(GetPackageDataWithServiceDataWithPackageIdQuery request, CancellationToken cancellationToken)
        {
            var getPackageRequest = new GetPackageByIdCommand
            {
                PakageId = request.PackageId
            };
            var getPackageResonse = await _mediator.Send(getPackageRequest);
            if (getPackageResonse == null)
            {
                throw new NotFoundException("Have no package!");
            }
            var packageService = await _dbContext.PackageService.Where(x => x.PackageId == getPackageResonse.Id).ToListAsync();
            if (!packageService.Any())
            {
                throw new NotFoundException("Have no package!");
            }
            var listService = new List<ServiceData>();
            foreach (var item in packageService)
            {
                var getServiceDataRequest = new GetServiceByIdQuery
                {
                    SerivceId = item.ServiceId.ToString()
                };
                var serviceData = await _mediator.Send(getServiceDataRequest);
                if (serviceData != null)
                {
                    listService.Add(serviceData);
                }
            }
            var result = new PackageDataAndServiceData
            {
                ListServiceData = listService,
                PackageData = getPackageResonse
            };
            return result;
        }
    }
}