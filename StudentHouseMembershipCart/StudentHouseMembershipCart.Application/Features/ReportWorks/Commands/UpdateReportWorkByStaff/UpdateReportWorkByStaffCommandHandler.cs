using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.UpdateReportWorkByStaff
{
    public class UpdateReportWorkByStaffCommandHandler : IRequestHandler<UpdateReportWorkByStaffCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;
        private IMapper _mapper;

        public UpdateReportWorkByStaffCommandHandler(IApplicationDbContext dbContext, IMediator mediator, IMapper mapper)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<SHMResponse> Handle(UpdateReportWorkByStaffCommand request, CancellationToken cancellationToken)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var reportWork = await _dbContext.ReportWork.Where(x => x.StaffId == request.StaffId &&
                                                              x.AttendReportId == request.AttendReportId).SingleOrDefaultAsync();
                if (reportWork == null)
                {
                    throw new BadRequestException("Can not found this report!");
                }
                if (reportWork.WorkingStatus == 1)
                {
                    throw new BadRequestException("This report has done!");
                }
                reportWork.DescriptionProcess = request.DescriptionProcess;
                reportWork.Image = request.ImageURL;
                reportWork.WorkingStatus = 1;
                reportWork.WorkingDayReport = request.WorkingDayReport;
                reportWork.ReportByStaffId = request.StaffId;

                _dbContext.ReportWork.Update(reportWork);
 Task.WaitAll();await _dbContext.SaveChangesAsync();Task.WaitAll();



                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}
