using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Queries.GetAttendReportByApartmentId
{
    public class GetAttendReportByApartmentIdCommandHandler : IRequestHandler<GetAttendReportByApartmentIdCommand, List<AttendReportData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAttendReportByApartmentIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<AttendReportData>> Handle(GetAttendReportByApartmentIdCommand request, CancellationToken cancellationToken)
        {
            var attendReportData = await _dbContext.AttendReport.Where(x => x.BookingDetailId == Guid.Parse(request.BookingDetailId)).ToListAsync();
            List<AttendReportData> response = new List<AttendReportData>();
            foreach (var item in attendReportData)
            {
                var atdRpData = _mapper.Map<AttendReportData>(item);
            }
            throw new NotImplementedException();
        }
    }
}