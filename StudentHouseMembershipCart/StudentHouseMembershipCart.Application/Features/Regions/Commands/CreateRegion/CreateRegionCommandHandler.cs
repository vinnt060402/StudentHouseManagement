using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Regions.Commands.CreateRegion
{
    public class CreateRegionCommandHandler : IRequestHandler<CreateRegionCommand, Guid>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public CreateRegionCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Guid> Handle(CreateRegionCommand request, CancellationToken cancellationToken)
        {
            // name co dinh : quan8, quan1, quan2, quan....
            var regionNameExist = await _context.Region.Where(r => r.RegionName == request.RegionName).FirstOrDefaultAsync();
            if (regionNameExist != null)
            {
                throw new NotFoundException("Region is exist!");
            }

            var entity = new Region { RegionName = request.RegionName };

            _context.Region.Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}