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
        private readonly IMapper _mapper;

        public GetListStaffQueryHandler(IApplicationDbContext context, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<List<StaffResponse>> Handle(GetListStaffQuery request, CancellationToken cancellationToken)
        {
            var staff = await _context.Staff.Where(x => !x.IsDelete).ToListAsync();
            var listResult = new List<StaffResponse>();
            foreach (var item in staff)
            {
                try
                {
                    var staffData = _mapper.Map<StaffData>(item);
                    var staffInfor = await _userManager.FindByIdAsync(item.ApplicationUserId);
                    var applicationStaffData = _mapper.Map<ApplicationStaff>(staffInfor);
                    var result = new StaffResponse
                    {
                        staffData = staffData,
                        inforOfStaffData = applicationStaffData,
                    };
                    listResult.Add(result);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return listResult;
        }
    }
}