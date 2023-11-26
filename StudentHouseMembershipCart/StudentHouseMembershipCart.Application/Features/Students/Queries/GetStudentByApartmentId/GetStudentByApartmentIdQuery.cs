using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByApartmentId
{
    public class GetStudentByApartmentIdQuery : IRequest<StudentDataNew>
    {
        public string PaymentnewId { get; set; }
    }
    public class GetStudentByApartmentIdQueryHandler : IRequestHandler<GetStudentByApartmentIdQuery, StudentDataNew>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public GetStudentByApartmentIdQueryHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<StudentDataNew> Handle(GetStudentByApartmentIdQuery request, CancellationToken cancellationToken)
        {
            var studentId = await (from b in _dbContext.Booking

                                   join a in _dbContext.Apartment

                                   on b.ApartmentId equals a.Id

                                   where b.PaymentNewId == request.PaymentnewId

                                   select a.StudentId).FirstOrDefaultAsync();

            var get = new GetStudentByStudentIdCommand()
            {
                StudentId = studentId,
            };
            var response = await _mediator.Send(get);
            return response;
        }
    }
}
