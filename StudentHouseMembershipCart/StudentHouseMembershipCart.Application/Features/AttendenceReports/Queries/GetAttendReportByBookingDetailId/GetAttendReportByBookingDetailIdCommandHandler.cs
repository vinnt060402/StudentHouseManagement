/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByBookingDetailId
{
    public class GetAttendReportByBookingDetailIdCommandHandler : IRequestHandler<GetAttendReportByBookingDetailIdCommand, AttendReportDataResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAttendReportByBookingDetailIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<AttendReportDataResponse> Handle(GetAttendReportByBookingDetailIdCommand request, CancellationToken cancellationToken)
        {
            var attendReportData = await _dbContext.AttendReport.Where(x => x.BookingDetailId == request.BookingDetailId).OrderBy(x => x.DateDoPackage).ToListAsync();
            List<AttendReportData> response = new List<AttendReportData>();
            foreach (var item in attendReportData)
            {
                var atdRpData = _mapper.Map<AttendReportData>(item);
                var feedback = await _dbContext.FeedBack.Where(x => x.AttendReportId == item.Id).SingleOrDefaultAsync();
                if (feedback != null)
                {
                    if (feedback.FeedBackStatus == 1)
                    {
                        atdRpData.FeedbackAvailable = "Can feedback";
                    }
                    else if (feedback.FeedBackStatus == 2)
                    {
                        atdRpData.FeedbackAvailable = "Feedbacked";
                    }
                    else
                    {
                        atdRpData.FeedbackAvailable = "Can not feedback";
                    }
                }
                else
                {
                    atdRpData.FeedbackAvailable = "Can not feedback";
                }
                response.Add(atdRpData);
            }
            var result = new AttendReportDataResponse();
            var bookingDetail = await _dbContext.BookingDetail.Where(x => x.Id == request.BookingDetailId).SingleOrDefaultAsync();
            result.BookingDetail = bookingDetail;
            result.AttendReports = response;
            return result;
        }
    }
}*/