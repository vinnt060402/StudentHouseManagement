using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByServiceId
{
    public class GetAttendReportByServiceIdQueryHandler : IRequestHandler<GetAttendReportByServiceIdQuery, List<NewAttendReportByService>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAttendReportByServiceIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<NewAttendReportByService>> Handle(GetAttendReportByServiceIdQuery request, CancellationToken cancellationToken)
        {
            var listAttendData = new List<AttendReport>();
            var attendDataOfBookingdetailPackage = await (from st in _dbContext.Student

                                                          join ap in _dbContext.Apartment

                                                          on st.Id equals ap.StudentId

                                                          join b in _dbContext.Booking

                                                          on ap.Id equals b.ApartmentId

                                                          join bdP in _dbContext.BookingDetailOfPakcage

                                                          on b.Id equals bdP.BookingId

                                                          join aR in _dbContext.AttendReport

                                                          on bdP.Id equals aR.BookingDetailId

                                                          where st.Id == request.StudentId
                                                          && aR.ServiceId == request.ServiceId
                                                          && b.StatusContract != 1
                                                          select new NewAttendReportByService()
                                                          {
                                                              AttendId = aR.Id,
                                                              Note = aR.Note,
                                                              ReportWorkId = aR.ReportWorkId,
                                                              ServiceId = aR.ServiceId,
                                                              ApartmentRegion = ap.Address,
                                                              AttendenceStatus = aR.AttendenceStatus,
                                                              AttendReportForType = aR.AttendReportForType,
                                                              AttendTittle = aR.AttendTittle,
                                                              BookingDetailId = aR.BookingDetailId,
                                                              DateDoService = aR.DateDoService,
                                                              //FeedbackAvailable = HandleFeedBackString(aR.Id).Result,
                                                          }).ToListAsync();
            var attendDataOfBookingdetailService = await (from st in _dbContext.Student

                                                          join ap in _dbContext.Apartment

                                                          on st.Id equals ap.StudentId

                                                          join b in _dbContext.Booking

                                                          on ap.Id equals b.ApartmentId

                                                          join bdS in _dbContext.BookingDetailOfService

                                                          on b.Id equals bdS.BookingId

                                                          join aR in _dbContext.AttendReport

                                                          on bdS.Id equals aR.BookingDetailId

                                                          where st.Id == request.StudentId
                                                          && aR.ServiceId == request.ServiceId
                                                          && b.StatusContract != 1
                                                          select new NewAttendReportByService()
                                                          {
                                                              AttendId = aR.Id,
                                                              Note = aR.Note,
                                                              ReportWorkId = aR.ReportWorkId,
                                                              ServiceId = aR.ServiceId,
                                                              ApartmentRegion = ap.Address,
                                                              AttendenceStatus = aR.AttendenceStatus,
                                                              AttendReportForType = aR.AttendReportForType,
                                                              AttendTittle = aR.AttendTittle,
                                                              BookingDetailId = aR.BookingDetailId,
                                                              DateDoService = aR.DateDoService,
                                                              //FeedbackAvailable = HandleFeedBackString(aR.Id).Result,
                                                          }).ToListAsync();

            List<NewAttendReportByService> result = new List<NewAttendReportByService>();
            if (attendDataOfBookingdetailPackage.Any())
            {
                var NewAttendReportByService = attendDataOfBookingdetailPackage;
                result.AddRange(NewAttendReportByService);
            }
            if (attendDataOfBookingdetailService.Any())
            {
                var NewAttendReportByService = attendDataOfBookingdetailService;
                result.AddRange(NewAttendReportByService);
            }
            result.OrderBy(x => x.DateDoService);
            foreach (var item in result)
            {
                var feedBackId = await _dbContext.FeedBack.Where(x => x.AttendReportId == item.AttendId).FirstOrDefaultAsync();
                if (feedBackId != null)
                {
                    item.FeedBackId = feedBackId.Id;
                }
                else
                {
                    item.FeedBackId = null;
                }
                item.Note = HandleNote(item.Note);
                item.FeedbackAvailable = await HandleFeedBackString(item.AttendId);
                item.FeedbackStatus = await HandleFeedBackStatus(item.AttendId);
            }
            var response = result.OrderBy(x => x.DateDoService).ToList();
            return await Task.FromResult(response);
        }
        private async Task<string> HandleFeedBackStatus(Guid AttendReportId)
        {
            var feedback = await _dbContext.FeedBack.Where(x => x.AttendReportId == AttendReportId).SingleOrDefaultAsync();
            if (feedback != null)
            {
                if (feedback.FeedBackStatus == 1)
                {
                    return "1";
                }
                else if (feedback.FeedBackStatus == 2)
                {
                    return "2";
                }
                else
                {
                    return "0";
                }
            }
            else
            {
                return "0";
            }
        }
        private async Task<string> HandleFeedBackString(Guid AttendReportId)
        {
            var feedback = await _dbContext.FeedBack.Where(x => x.AttendReportId == AttendReportId).SingleOrDefaultAsync();
            if (feedback != null)
            {
                if (feedback.FeedBackStatus == 1)
                {
                    return "Can feedback";
                }
                else if (feedback.FeedBackStatus == 2)
                {
                    return "Feedbacked";
                }
                else
                {
                    return "Can not feedback";
                }
            }
            else
            {
                return "Can not feedback";
            }
        }
        private string HandleNote(string note)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(note))
            {
                return result;
            }
            int noteIndex = note.IndexOf("Quantity to do: ");
            if (noteIndex != -1)
            {
                result = note.Substring(0, noteIndex);
            }
            else
            {
                result = note;
            }
            return result;
        }
    }
}
