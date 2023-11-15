using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.StaffCategories.Commands.DeleteStaffCategoryByStaffId
{
    public class DeleteStaffCategoryByStaffIdComandHandler : IRequestHandler<DeleteStaffCategoryByStaffIdComand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public DeleteStaffCategoryByStaffIdComandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(DeleteStaffCategoryByStaffIdComand request, CancellationToken cancellationToken)
        {
            var listStaffCategory = await _dbContext.StaffCategory.Where(x => x.StaffId == Guid.Parse(request.StaffId)).ToListAsync();
            foreach (var item in listStaffCategory)
            {
                item.IsDelete = true;
            }
            if (listStaffCategory.Any())
            {
                _dbContext.StaffCategory.UpdateRange(listStaffCategory);
            }
            else
            {
                throw new NotFoundException("Does not existed Staff ID like that!!");
            }
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}