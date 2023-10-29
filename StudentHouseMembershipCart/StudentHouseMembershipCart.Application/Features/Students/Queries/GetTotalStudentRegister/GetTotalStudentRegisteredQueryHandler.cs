using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetTotalStudentRegister
{
    public class GetTotalStudentRegisteredQueryHandler : IRequestHandler<GetTotalStudentRegisteredQuery, int>
    {
        private IApplicationDbContext _dbContext;

        public GetTotalStudentRegisteredQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(GetTotalStudentRegisteredQuery request, CancellationToken cancellationToken)
        {
            var student = await _dbContext.Student.ToListAsync();
            var total = student.Count;
            return total;
        }
    }
}
