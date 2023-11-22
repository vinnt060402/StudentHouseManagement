using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById
{
    public class GetPakageByIdCommandHandler : IRequestHandler<GetPackageByIdCommand, PackageData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetPakageByIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<PackageData> Handle(GetPackageByIdCommand request, CancellationToken cancellationToken)
        {
            var package = await _dbContext.Package.AsNoTracking().Where(x => x.Id == Guid.Parse(request.PakageId)).SingleOrDefaultAsync();
            if (package == null)
            {
                throw new NotFoundException("Have no package!");
            }
            var result = _mapper.Map<PackageData>(package);
            return result;
        }
    }
}