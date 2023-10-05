using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment
{
    public class GetListApartmentQueryHandler : IRequestHandler<GetListApartmentQuery, List<ApartmentDto>>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public GetListApartmentQueryHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<List<ApartmentDto>> Handle(GetListApartmentQuery request, CancellationToken cancellationToken)
        {
            var list = await _context.Apartment.Where(s => s.IsDelete == false)
                .Include(s => s.Student)
                .Include(s => s.Region)
                .ProjectTo<ApartmentDto>(_mapper.ConfigurationProvider).ToListAsync();
            if(list == null) {
                throw new NotFoundException(nameof(Apartment));
            }

            return list;
        }
    }
}
