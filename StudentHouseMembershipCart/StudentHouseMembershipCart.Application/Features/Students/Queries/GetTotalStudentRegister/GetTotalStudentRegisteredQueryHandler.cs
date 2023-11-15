using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetTotalStudentRegister
{
    public class GetTotalStudentRegisteredQueryHandler : IRequestHandler<GetTotalStudentRegisteredQuery, TotalStudentRegistered>
    {
        private IApplicationDbContext _dbContext;

        public GetTotalStudentRegisteredQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TotalStudentRegistered> Handle(GetTotalStudentRegisteredQuery request, CancellationToken cancellationToken)
        {
            var student = await _dbContext.Student.ToListAsync();
            var total = student.Count;
            return new TotalStudentRegistered
            {
                TotalNumber = total
            };
        }
    }
}