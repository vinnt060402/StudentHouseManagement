using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff
{
    public class GetListStaffQueryHandler : IRequestHandler<GetListStaffQuery, List<StaffResponse>>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IStaffRepository _staffRepository;

        public GetListStaffQueryHandler(IApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, IMapper mapper, IStaffRepository staffRepository)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _staffRepository = staffRepository;
        }
        public async Task<List<StaffResponse>> Handle(GetListStaffQuery request, CancellationToken cancellationToken)
        {
            var staff = await _context.Staff.Where(x => !x.IsDelete).ToListAsync();
            if (!staff.Any())
            {
                throw new NotFoundException("Have no Staff!");
            }
            var listResult = new List<StaffResponse>();
            foreach (var item in staff)
            {
                var staffInfor = await _userManager.FindByIdAsync(item.ApplicationUserId);
                var result = new StaffResponse
                {
                    staffData = item,
                    inforOfStaffData = staffInfor,
                };
                listResult.Add(result);
            }
            return listResult;
        }
    }
}
