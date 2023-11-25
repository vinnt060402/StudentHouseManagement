using MediatR;
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
                var numberInTittle = request.BookingDetailTittle.Substring(request.BookingDetailTittle.Length - 3);
                var checkAttendReportHaveReportWork = await _dbContext.AttendReport.Where(x => x.BookingDetailId == request.BookingDetailId &&
                                                                                         x.AttendReportForType == request.BookingDetailType &&
                                                                                         x.AttendTittle!.Contains(numberInTittle)
                                                                                         ).ToListAsync();
                bool flag = true;
                foreach(var check in checkAttendReportHaveReportWork)
                {
                    if(check.ReportWorkId.HasValue)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    throw new BadRequestException("This booking detail have been asign for another one"!);
                }
                var list = new List<ReportWork>();
                foreach(var item in checkAttendReportHaveReportWork)
                {
                    var reportWork = new ReportWork
                    {
                        WorkingDayExpect = item.DateDoService,
                        WorkingStatus = 0,
                        StaffId = request.StaffId,
                        AttendReportId = item.Id
                    };
                    list.Add(reportWork);
                    item.ReportWorkId = reportWork.Id;
                    _dbContext.AttendReport.Update(item);
                }
                list.OrderBy(x => x.WorkingDayExpect);
                _dbContext.ReportWork.AddRange(list);
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