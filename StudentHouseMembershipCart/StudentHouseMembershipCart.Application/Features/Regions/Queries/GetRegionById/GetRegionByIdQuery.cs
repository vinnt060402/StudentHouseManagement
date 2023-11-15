using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Regions.Queries.GetRegionById
{
    public class GetRegionByIdQuery : IRequest<RegionDto>
    {
        public Guid Id { get; set; }
    }

    public class GetRegionByIdQueryHandler : IRequestHandler<GetRegionByIdQuery, RegionDto>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public GetRegionByIdQueryHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<RegionDto> Handle(GetRegionByIdQuery request, CancellationToken cancellationToken)
        {
            var region = _context.Region.Where(r => r.Id == request.Id).AsNoTracking();

            if (region == null || region.Count() == 0)
            {
                throw new NotFoundException(nameof(RegionDto), request.Id);
            }
            var map = region.ProjectTo<RegionDto>(_mapper.ConfigurationProvider);
            var regionData = await map.FirstOrDefaultAsync();
            return regionData;
        }
    }
}