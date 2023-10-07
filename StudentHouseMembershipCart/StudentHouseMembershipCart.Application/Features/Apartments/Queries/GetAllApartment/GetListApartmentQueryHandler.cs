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
            /*var apartmentList = await _context.Apartment.Where(s => s.IsDelete == false)
                .Include(a => a.Student)
                .Include(a => a.Region)
                .ToListAsync();
            if (!apartmentList.Any()) {
                throw new NotFoundException(nameof(Apartment));
            }

            var listResult = new List<ApartmentResponse>();
            foreach (var item in apartmentList) {
                var studentInfo = await _context.Student.Where(s => s.Id == item.StudentId).SingleOrDefaultAsync();
                var regionInfo = await _context.Region.Where(s => s.Id == item.RegionId).SingleOrDefaultAsync();
                var result = new ApartmentResponse
                {
                    InforApartmentData = item,
                    InforStudentData = studentInfo,
                    InforRegionData = regionInfo
                };
                listResult.Add(result);
            }*/
            var apartments = await _context.Apartment
                .Join(_context.Student,
                      apartment => apartment.StudentId,
                      student => student.Id,
                      (apartment, student) => new { Apartment = apartment, Student = student })
                .Join(_context.Region,
                      combined => combined.Apartment.RegionId,
                      region => region.Id,
                      (combined, region) => new ApartmentResponse
                      {
                          InforApartmentData = combined.Apartment,
                          InforStudentData = combined.Student,
                          InforRegionData = region
                      })
                .Where(s => !s.InforApartmentData.IsDelete)
                .ToListAsync();

            return apartments;
        }
    }
}
