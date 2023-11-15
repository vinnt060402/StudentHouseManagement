using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment
{
    public class GetListApartmentQueryHandler : IRequestHandler<GetListApartmentQuery, List<ApartmentResponse>>
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

        public async Task<List<ApartmentResponse>> Handle(GetListApartmentQuery request, CancellationToken cancellationToken)
        {
            var apartments = await _context.Apartment.Where(s => !s.IsDelete)
                                .Join(
                                    _context.Student,
                                    apartment => apartment.StudentId,
                                    student => student.Id,
                                    (apartment, student) => new
                                    {
                                        Apartment = apartment,
                                        Student = student
                                    }
                                )
                                .Join(
                                    _context.Region,
                                    combined => combined.Apartment.RegionId,
                                    region => region.Id,
                                    (combined, region) => new ApartmentResponse
                                    {
                                        Id = combined.Apartment.Id,
                                        Address = combined.Apartment.Address,
                                        RegionId = combined.Apartment.RegionId,
                                        StudentId = combined.Apartment.StudentId,
                                        InforStudentData = combined.Student,
                                        InforRegionData = region,
                                    }
                                )
                                .ToListAsync();
            return apartments;
        }
    }
}