using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Services.Queries.ReadServiceById
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, ServiceData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetServiceByIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ServiceData> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var service = await _dbContext.Service.Where(x => x.Id == Guid.Parse(request.SerivceId)).SingleOrDefaultAsync();
            if (service == null)
            {
                throw new NotFoundException("Have no service!");
            }
            var response = _mapper.Map<ServiceData>(service);
            return response;
        }
    }
}