using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.UpdateAttendenceReportWithReportWorkId;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.CreateReportWork
{
    public class CreateReportWorkCommandHandler : IRequestHandler<CreateReportWorkCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public CreateReportWorkCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreateReportWorkCommand request, CancellationToken cancellationToken)
        {
/*            var attendenceReport = await _dbContext.AttendReport.Where(x => x.BookingDetailId == Guid.Parse(request.BookingDetailId)).ToListAsync();
            if (!attendenceReport.Any())
            {
                //Bởi vì mặc định khi được booking xong sẽ tự động sinh ra records có chứa bookingdetailid 
                //ở attendence, nên nếu không tìm thấy thì có thể nó đã bị xóa hoặc chưa tạo
                throw new NotFoundException("This booking detail is not register before");
            }
            List<ReportWork> listRecord = new List<ReportWork>();
            foreach (var atR in attendenceReport)
            {
                var reportWorkRecord = new ReportWork()
                {
                    DescriptionProcess = null,
                    Image = null,
                    StaffId = Guid.Parse(request.StaffId),
                    AttendReportId = atR.Id,
                    IsDelete = false,
                    AlternativeReason = null,
                    ReportByStaffId = null,
                    WorkingDayExpect = atR.DateDoPackage,
                    WorkingDayReport = null,
                    WorkingStatus = 0
                };
                listRecord.Add(reportWorkRecord);
                //Update field ReportworkId vô trong AttendReport
                var updateAttendReport = new UpdateAttendenceReportWithReportWorkIdCommand
                {
                    AttendenceReportId = atR.Id.ToString(),
                    ReportWorkId = reportWorkRecord.Id.ToString()
                };
                var updateAttendReportResponse = await _mediator.Send(updateAttendReport);
            }
            _dbContext.ReportWork.AddRange(listRecord);
            await _dbContext.SaveChangesAsync();*/
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
    }
}