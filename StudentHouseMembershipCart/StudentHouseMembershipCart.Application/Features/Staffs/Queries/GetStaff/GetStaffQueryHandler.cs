using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff
{
    public class GetStaffQueryHandler : IRequestHandler<GetStaffQuery, StaffResponse>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public GetStaffQueryHandler(IApplicationDbContext context, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<StaffResponse> Handle(GetStaffQuery request, CancellationToken cancellationToken)
        {
            var staff = await _context.Staff.Where(x => x.Id == request.Id).SingleOrDefaultAsync();
            if (staff == null)
            {
                throw new NotFoundException("Have no Staff!");
            }
            var listResult = new List<StaffResponse>();
            var staffData = _mapper.Map<StaffData>(staff);
            var staffInfor = await _userManager.FindByIdAsync(staff.ApplicationUserId);
            var applicationStaffData = _mapper.Map<ApplicationStaff>(staffInfor);
            var result = new StaffResponse
            {
                staffData = staffData,
                inforOfStaffData = applicationStaffData,
            };
            return result;
        }
    }
}