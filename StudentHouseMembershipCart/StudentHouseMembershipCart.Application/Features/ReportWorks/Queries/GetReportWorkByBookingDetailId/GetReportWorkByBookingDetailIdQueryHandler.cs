using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByBookingDetailId
{
    public class GetReportWorkByBookingDetailIdQueryHandler : IRequestHandler<GetReportWorkByBookingDetailIdQuery, List<ReportWorkData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetReportWorkByBookingDetailIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ReportWorkData>> Handle(GetReportWorkByBookingDetailIdQuery request, CancellationToken cancellationToken)
        {
            var listRW = await (from rw in _dbContext.ReportWork
                                join ar in _dbContext.AttendReport
                                on rw.AttendReportId equals ar.Id
                                where ar.BookingDetailId == Guid.Parse(request.BookingDetailId)
                                select new ReportWorkData
                                {
                                    AlternativeReason = rw.AlternativeReason,
                                    DescriptionProcess = rw.DescriptionProcess,
                                    Image = rw.Image,
                                    ReportByStaffId = rw.ReportByStaffId,
                                    StaffSubstitableId = rw.StaffSubstitableId,
                                    WorkingDayExpect = rw.WorkingDayExpect,
                                    WorkingDayReport = rw.WorkingDayReport,
                                    WorkingStatus = rw.WorkingStatus
                                }
                                ).ToListAsync();
            if (!listRW.Any())
            {
                throw new NotFoundException("Do not have this booking detail for staff!!");
            }
            return listRW;
        }
    }
}