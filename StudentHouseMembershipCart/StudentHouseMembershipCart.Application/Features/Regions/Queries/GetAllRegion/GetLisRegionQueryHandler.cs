using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Regions.Queries.GetAllRegion
{
    public class GetLisRegionQueryHandler : IRequestHandler<GetListRegionQuery, List<RegionDto>>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public GetLisRegionQueryHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<List<RegionDto>> Handle(GetListRegionQuery request, CancellationToken cancellationToken)
        {
            var list = await _context.Region.Where(r => r.IsDelete == false)
                .ProjectTo<RegionDto>(_mapper.ConfigurationProvider).ToListAsync();
            if (list == null)
            {
                throw new NotFoundException(nameof(Region));
            }

            return list;
        }
    }
}