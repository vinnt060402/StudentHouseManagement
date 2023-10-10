using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById
{
    public class GetPakageByIdCommandHandler : IRequestHandler<GetPakageByIdCommand, PackageData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetPakageByIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PackageData> Handle(GetPakageByIdCommand request, CancellationToken cancellationToken)
        {
            var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(request.PakageId)).SingleOrDefaultAsync();
            if (package == null)
            {
                throw new NotFoundException("Have no package!");
            }
            var response = _mapper.Map<PackageData>(package);
            return response;
        }
    }
}
