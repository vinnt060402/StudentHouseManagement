using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackStatusByReportWorked;
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
                //Sau khi update ReportWork thì sửa status của attendreport 
                var attendenceReport = await _dbContext.AttendReport.Where(x => x.Id == request.AttendReportId).FirstOrDefaultAsync();
                if (attendenceReport == null)
                {
                    throw new BadRequestException("Can not found this report!");
                }
                attendenceReport.AttendenceStatus = 1;
                _dbContext.AttendReport.Update(attendenceReport);
                //Sau khi sửa status của attendreport, sửa status của feedback
                var updateFeedbackStatus = new UpdateFeedBackStatusByReportWorkedCommand()
                {
                    AttendReportId = request.AttendReportId
                };
                var updateFeedbackStatusResponse = _mediator.Send(updateFeedbackStatus);

                var bookingDetail = await (from bd in _dbContext.BookingDetail
                                           join ar in _dbContext.AttendReport
                                           on bd.Id equals ar.BookingDetailId
                                           where ar.Id == request.AttendReportId
                                           select bd).FirstOrDefaultAsync();
                if (bookingDetail == null)
                {
                    throw new BadRequestException("Somethings is wrong!!");
                }
                bookingDetail.RemainingTaskDuration = bookingDetail.RemainingTaskDuration - 1;
                _dbContext.BookingDetail.Update(bookingDetail);
                if (bookingDetail.RemainingTaskDuration == 0)
                {
                    /// <summary>
                    /// 0. On going
                    /// 1. Finished
                    /// </summary>
                    bookingDetail.BookingDetailStatus = 1;
                    //Check all bookingdetail of booking
                    var listBookingdetail = await _dbContext.BookingDetail.Where(x => x.BookingId == bookingDetail.BookingId).ToListAsync();
                    var totalBDinB = listBookingdetail.Count;
                    var flag = 0;
                    foreach (var item in listBookingdetail)
                    {
                        if (item.RemainingTaskDuration == 0)
                        {
                            flag++;
                        }
                    }
                    if (flag == totalBDinB)
                    {
                        var booking = await _dbContext.Booking.Where(x => x.Id == bookingDetail.BookingId).FirstOrDefaultAsync();
                        if (booking == null)
                        {
                            throw new BadRequestException("Somethings is wrong!!");
                        }
                        else
                        {
                            /// <summary>
                            /// 0. On going
                            /// 1. Finished
                            /// </summary>
                            booking.StatusContract = 1;
                            _dbContext.Booking.Update(booking);
                        }
                    }
                }
                await _dbContext.SaveChangesAsync();
                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}
