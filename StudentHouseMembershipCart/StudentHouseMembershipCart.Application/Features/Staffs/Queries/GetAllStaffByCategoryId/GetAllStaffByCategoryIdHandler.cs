using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetAllStaffByCategoryId
{
    public class GetAllStaffByCategoryIdHandler : IRequestHandler<GetAllStaffByCategoryIdQuery, List<StaffResponse>>
    {
        private IApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private IMapper _mapper;

        public GetAllStaffByCategoryIdHandler(IApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<List<StaffResponse>> Handle(GetAllStaffByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var listStaff = await (from staff in _dbContext.Staff
                                   join staffCategory in _dbContext.StaffCategory
                                   on staff.Id equals staffCategory.StaffId
                                   join cate in _dbContext.Category
                                   on staffCategory.CategoryId equals cate.Id
                                   join service in _dbContext.Service
                                   on cate.Id equals service.CategoryId
                                   where service.Id == Guid.Parse(request.ServiceId)
                                   select staff
                                   ).ToListAsync();
            var listResult = new List<StaffResponse>();
            foreach (var item in listStaff)
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