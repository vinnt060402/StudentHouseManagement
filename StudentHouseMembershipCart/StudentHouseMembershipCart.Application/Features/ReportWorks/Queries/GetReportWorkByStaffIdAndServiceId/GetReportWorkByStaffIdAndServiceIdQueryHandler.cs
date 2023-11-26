using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByBookingDetailId;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByStaffIdAndServiceId
{
    public class GetReportWorkByStaffIdAndServiceIdQueryHandler : IRequestHandler<GetReportWorkByStaffIdAndServiceIdQuery, List<ReportWorkData>>
    {
        private IApplicationDbContext _dbContext;

        public GetReportWorkByStaffIdAndServiceIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ReportWorkData>> Handle(GetReportWorkByStaffIdAndServiceIdQuery request, CancellationToken cancellationToken)
        {
            var listRW = await (from rw in _dbContext.ReportWork
                                join ar in _dbContext.AttendReport
                                on rw.AttendReportId equals ar.Id
                                where
                                ar.ServiceId == request.ServiceId &&
                                rw.StaffId == request.StaffId
                                orderby rw.WorkingDayExpect
                                select new { rw,ar} /*new ReportWorkData
                                {
                                    AlternativeReason = rw.AlternativeReason,
                                    DescriptionProcess = rw.DescriptionProcess,
                                    Image = rw.Image,
                                    ReportByStaffId = rw.ReportByStaffId,
                                    StaffSubstitableId = rw.StaffSubstitableId,
                                    WorkingDayExpect = rw.WorkingDayExpect,
                                    WorkingDayReport = rw.WorkingDayReport,
                                    WorkingStatus = rw.WorkingStatus
                                }*/
                                ).ToListAsync();
            var result = new List<ReportWorkData>();
            foreach (var item in listRW)
            {
                var workingAt = string.Empty;
                var ar = _dbContext.AttendReport.Where(x => x.ReportWorkId == item.rw.Id).FirstOrDefault();
                if (ar != null)
                {
                    if (ar.AttendReportForType == "1")
                    {
                        var a = await (from ap in _dbContext.Apartment

                                       join b in _dbContext.Booking

                                       on ap.Id equals b.ApartmentId

                                       join bdP in _dbContext.BookingDetailOfPakcage

                                       on b.Id equals bdP.BookingId

                                       where bdP.Id == ar.BookingDetailId
                                       select ap.Address).FirstOrDefaultAsync();
                        var rw = new ReportWorkData
                        {
                            AttendReportId = item.ar.Id,
                            AlternativeReason = item.rw.AlternativeReason,
                            DescriptionProcess = item.rw.DescriptionProcess,
                            Image = item.rw.Image,
                            ReportByStaffId = item.rw.ReportByStaffId,
                            StaffSubstitableId = item.rw.StaffSubstitableId,
                            WorkingDayExpect = item.rw.WorkingDayExpect,
                            WorkingDayReport = item.rw.WorkingDayReport,
                            WorkingStatus = item.rw.WorkingStatus,
                            WorkingAt = "Working at " + a
                        };
                        result.Add(rw);
                    }
                    else if (ar.AttendReportForType == "2")
                    {
                        var a = await (from ap in _dbContext.Apartment

                                       join b in _dbContext.Booking

                                       on ap.Id equals b.ApartmentId

                                       join bdP in _dbContext.BookingDetailOfService

                                       on b.Id equals bdP.BookingId

                                       where bdP.Id == ar.BookingDetailId
                                       select ap.Address).FirstOrDefaultAsync();
                        var rw = new ReportWorkData
                        {
                            AttendReportId = item.ar.Id,
                            AlternativeReason = item.rw.AlternativeReason,
                            DescriptionProcess = item.rw.DescriptionProcess,
                            Image = item.rw.Image,
                            ReportByStaffId = item.rw.ReportByStaffId,
                            StaffSubstitableId = item.rw.StaffSubstitableId,
                            WorkingDayExpect = item.rw.WorkingDayExpect,
                            WorkingDayReport = item.rw.WorkingDayReport,
                            WorkingStatus = item.rw.WorkingStatus,
                            WorkingAt = "Working at " + a
                        };
                        result.Add(rw);
                    }
                }
            }
            return result;
        }
    }
}
