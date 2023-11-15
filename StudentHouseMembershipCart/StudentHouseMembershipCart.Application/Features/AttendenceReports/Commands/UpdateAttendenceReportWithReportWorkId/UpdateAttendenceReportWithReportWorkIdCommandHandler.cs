using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.UpdateAttendenceReportWithReportWorkId
{
    public class UpdateAttendenceReportWithReportWorkIdCommandHandler : IRequestHandler<UpdateAttendenceReportWithReportWorkIdCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdateAttendenceReportWithReportWorkIdCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Dùng để Update Field ReportWork khi staff được Admin assign task 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<SHMResponse> Handle(UpdateAttendenceReportWithReportWorkIdCommand request, CancellationToken cancellationToken)
        {
            var aR = await _dbContext.AttendReport.Where(x => x.Id == Guid.Parse(request.AttendenceReportId)).SingleOrDefaultAsync();
            if (aR == null)
            {
                throw new NotFoundException("Do not have this Attendence report before");
            }
            aR.ReportWorkId = Guid.Parse(request.ReportWorkId);

            _dbContext.AttendReport.Update(aR);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse()
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}