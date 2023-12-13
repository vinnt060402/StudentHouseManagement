using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBookingDoNotAssignBefore
{
    public class GetAllBookingDoNotAssignBeforeQueryHandler : IRequestHandler<GetAllBookingDoNotAssignBeforeQuery, List<BookingDetailDoNotAssignBeforeData>>
    {
        private IApplicationDbContext _dbContext;

        public GetAllBookingDoNotAssignBeforeQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BookingDetailDoNotAssignBeforeData>> Handle(GetAllBookingDoNotAssignBeforeQuery request, CancellationToken cancellationToken)
        {
            List<BookingDetailDoNotAssignBeforeData> result = new List<BookingDetailDoNotAssignBeforeData>();

            var attendData = await _dbContext.AttendReport.Where(x => x.ReportWorkId == null || !x.ReportWorkId.HasValue).OrderBy(x => x.DateDoService).ToListAsync();

            foreach (var attend in attendData)
            {
                if(!result.Any())
                {
                    var donotAssignBefore = new BookingDetailDoNotAssignBeforeData()
                    {
                        BookingDetailTittle = HandleBookingDetailTittle(attend.AttendTittle!),
                        StartDateDoService = attend.DateDoService.ToString("yyyy/MM/dd"),
                        EndDateDoService = attend.DateDoService.ToString("yyyy/MM/dd"),
                        TimeDoService = attend.DateDoService.ToString("HH:mm"),
                        ServiceId = attend.ServiceId,
                        BookingDetailId = attend.BookingDetailId,
                        BookingDetailType = attend.AttendReportForType,
                        Note = HandleNote(attend.Note!)
                    };
                    result.Add(donotAssignBefore);
                }
                else
                {
                    var donotAssignBefore = new BookingDetailDoNotAssignBeforeData()
                    {
                        BookingDetailTittle = HandleBookingDetailTittle(attend.AttendTittle!),
                        StartDateDoService = attend.DateDoService.ToString("yyyy/MM/dd"),
                        EndDateDoService = attend.DateDoService.ToString("yyyy/MM/dd"),
                        TimeDoService = attend.DateDoService.ToString("HH:mm"),
                        ServiceId = attend.ServiceId,
                        BookingDetailId = attend.BookingDetailId,
                        BookingDetailType = attend.AttendReportForType,
                        Note = HandleNote(attend.Note!)  
                    };
                    var checkdonotAssignBeforeExist = result.Where(x => x.BookingDetailTittle == donotAssignBefore.BookingDetailTittle &&
                                                                        x.ServiceId ==  donotAssignBefore.ServiceId &&
                                                                        x.BookingDetailId == donotAssignBefore.BookingDetailId &&
                                                                        x.BookingDetailType == donotAssignBefore.BookingDetailType).FirstOrDefault();
                    if (checkdonotAssignBeforeExist == null)
                    {
                        result.Add(donotAssignBefore);
                    }else
                    {
                        result.Remove(checkdonotAssignBeforeExist);
                        checkdonotAssignBeforeExist.EndDateDoService = attend.DateDoService.ToString("yyyy/MM/dd");
                        result.Add(checkdonotAssignBeforeExist);
                    }
                }
            }
            return result;
        }
        //17
        private string HandleBookingDetailTittle(string AttendTittle)
        {
            string result = string.Empty;
            int dateIndex = AttendTittle.IndexOf(", Date: ");
            if(dateIndex != -1)
            {
                result = AttendTittle.Substring(0, dateIndex) + AttendTittle.Substring(dateIndex + 24); 
            }
            return result;
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
