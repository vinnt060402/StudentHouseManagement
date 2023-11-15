using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByApartmentId
{
    public class GetApartmentByApartmentIdQueryHandler : IRequestHandler<GetApartmentByApartmentIdQuery, ApartmentDto>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetApartmentByApartmentIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApartmentDto> Handle(GetApartmentByApartmentIdQuery request, CancellationToken cancellationToken)
        {
            var apartment = await _dbContext.Apartment.Where(x => x.Id == request.ApartmentId).SingleOrDefaultAsync();
            var result = _mapper.Map<ApartmentDto>(apartment);
            return result;
        }
    }
}