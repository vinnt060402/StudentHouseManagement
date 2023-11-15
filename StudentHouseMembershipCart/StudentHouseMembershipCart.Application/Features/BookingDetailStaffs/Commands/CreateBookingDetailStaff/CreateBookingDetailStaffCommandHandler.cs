/*using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.CreateReportWork;
using StudentHouseMembershipCart.Domain.Entities;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.BookingDetailStaffs.Commands.CreateBookingDetailStaff
{
    public class CreateBookingDetailStaffCommandHandler : IRequestHandler<CreateBookingDetailStaffCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public CreateBookingDetailStaffCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreateBookingDetailStaffCommand request, CancellationToken cancellationToken)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var checkExistedAssign = await _dbContext.BookingDetailStaff.Where(x => x.BookingDetailId == Guid.Parse(request.BookingDetailId)).SingleOrDefaultAsync();
                if (checkExistedAssign != null)
                {
                    throw new BadRequestException("This booking detail have been asign for another one"!);
                }
                var checkExistedAssignInAttendReport = await _dbContext.AttendReport.Where(x => x.BookingDetailId == Guid.Parse(request.BookingDetailId)).ToListAsync();
                if (checkExistedAssignInAttendReport.Any())
                {
                    foreach (var atd in checkExistedAssignInAttendReport)
                    {
                        if (atd.ReportWorkId.HasValue)
                        {
                            throw new BadRequestException("This booking detail have been asign for another one"!);
                        }
                    }
                }
                var bdS = new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse(request.BookingDetailId),
                    StaffId = Guid.Parse(request.StaffId),
                    CreateBy = request.AssignBy
                };
                _dbContext.BookingDetailStaff.Add(bdS);
                //After create Bookingdetail staff
                //Coutinue create ReportWork of staff
                var createReportWork = new CreateReportWorkCommand
                {
                    BookingDetailId = request.BookingDetailId,
                    StaffId = request.StaffId
                };
                var createReportWorkResponse = await _mediator.Send(createReportWork);
                await _dbContext.SaveChangesAsync();

                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
    }
}
*/