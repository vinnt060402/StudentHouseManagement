using AutoMapper;
using FluentValidation.Results;
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
                var updateFeedbackStatusResponse = await _mediator.Send(updateFeedbackStatus);
                Guid localVariable = Guid.NewGuid();
                var attendDataToupdate = _dbContext.AttendReport.Where(x => x.Id == request.AttendReportId).FirstOrDefault();
                if (attendDataToupdate != null)
                {
                    /*
                     * Nếu RemainTaskDuration của BookingDetail đó = 0 và tất cả các ngày trong AttendReport Được làm thành công
                     * Thì Booking Detail đó sẽ Finish
                     * Check tiếp theo là check all booking detail của booking đó đã được thành công hay chưa, xong hết r thì cập nhật luôn booking
                     */
                    bool flagBookingDetailFinish = false;
                    var serviceRemmainTaskDuration = _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == attendDataToupdate.BookingDetailId &&
                                                                                                        x.ServiceId == attendDataToupdate.ServiceId &&
                                                                                                        x.AttendReportForType == attendDataToupdate.AttendReportForType).FirstOrDefault();
                    if (serviceRemmainTaskDuration != null && serviceRemmainTaskDuration.RemainingTaskDuration == 0)
                    {
                        flagBookingDetailFinish = true;
                        //Kiểm tra xem tất cả attendreportdata đã được làm xong hết hay chưa
                        var listAttendData = await _dbContext.AttendReport.Where(x => x.BookingDetailId == serviceRemmainTaskDuration.BookingDetailId).ToListAsync();
                        var cout = listAttendData.Where(x => x.AttendenceStatus == 0).ToList().Count;
                        if (cout > 0)
                        {
                            flagBookingDetailFinish = false;
                        }
                        else
                        {
                            if (serviceRemmainTaskDuration.AttendReportForType == "1")
                            {
                                var bookingDetail = await _dbContext.BookingDetailOfPakcage.Where(x => x.Id == serviceRemmainTaskDuration.BookingDetailId).FirstOrDefaultAsync();
                                if (bookingDetail != null)
                                {
                                    bookingDetail.BookingDetailStatus = 1;
                                    localVariable = bookingDetail.BookingId;
                                    _dbContext.BookingDetailOfPakcage.Update(bookingDetail);
                                }
                            }
                            else if (serviceRemmainTaskDuration.AttendReportForType == "2")
                            {
                                var bookingDetail = await _dbContext.BookingDetailOfService.Where(x => x.Id == serviceRemmainTaskDuration.BookingDetailId).FirstOrDefaultAsync();
                                if (bookingDetail != null)
                                {
                                    bookingDetail.BookingDetailStatus = 1;
                                    localVariable = bookingDetail.BookingId;
                                    _dbContext.BookingDetailOfService.Update(bookingDetail);
                                }
                            }
                        }

                    }

                }
                var flagCheckBookingFinish = true;
                var bookingDetailPackageOfBooking = await _dbContext.BookingDetailOfPakcage.Where(x => x.BookingId == localVariable).ToListAsync();
                if (bookingDetailPackageOfBooking.Any())
                {
                    var count = bookingDetailPackageOfBooking.Where(x => x.BookingDetailStatus == 0).Count();
                    if (count > 0)
                    {
                        flagCheckBookingFinish = false;
                    }
                }
                var bookingDetailPackageOfService = await _dbContext.BookingDetailOfService.Where(x => x.BookingId == localVariable).ToListAsync();
                if (bookingDetailPackageOfService.Any())
                {
                    var count = bookingDetailPackageOfService.Where(x => x.BookingDetailStatus == 0).Count();
                    if (count > 0)
                    {
                        flagCheckBookingFinish = false;
                    }
                }
                if (flagCheckBookingFinish)
                {
                    var booking = await _dbContext.Booking.Where(x => x.Id == localVariable).FirstOrDefaultAsync();
                    if (booking != null)
                    {
                        booking.StatusContract = 1;
                        _dbContext.Booking.Update(booking);
                    }
                }

                Task.WaitAll();
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