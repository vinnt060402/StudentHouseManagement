using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStudentId;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStaffId
{
    public class ServiceOfBookingDetailOfStaff
    {
        public string? ServiceName { get; set; }
        public Guid ServiceId { get; set; }
        /// <summary>
        /// Đại diện đơn vị
        /// </summary>
        public string? Unit { get; set; }
    }
    public class GetServiceOfBookingDetailByStaffIdQueryHandler : IRequestHandler<GetServiceOfBookingDetailByStaffIdQuery, List<ServiceOfBookingDetailOfStaff>>
    {
        private IApplicationDbContext _dbContext;

        public GetServiceOfBookingDetailByStaffIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ServiceOfBookingDetailOfStaff>> Handle(GetServiceOfBookingDetailByStaffIdQuery request, CancellationToken cancellationToken)
        {
            var listattendreport = await (from rw in _dbContext.ReportWork

                                            join ar in _dbContext.AttendReport

                                            on rw.Id equals ar.ReportWorkId

                                            where
                                            rw.StaffId == request.StaffId

                                            select ar
                                            ).ToListAsync();
            List<Guid> listServiceId = new List<Guid>();
            foreach(var item in listattendreport)
            {
                if (!listServiceId.Any())
                {
                    listServiceId.Add(item.ServiceId);
                }
                if (!listServiceId.Contains(item.ServiceId))
                {
                    listServiceId.Add(item.ServiceId);
                }
            }
            List<ServiceOfBookingDetailOfStaff> result = new List<ServiceOfBookingDetailOfStaff>();
            foreach(var item in listServiceId)
            {
                var service = await _dbContext.Service.Where(x => x.Id == item).SingleOrDefaultAsync();
                if (service != null)
                {
                    var data = new ServiceOfBookingDetailOfStaff
                    {
                        ServiceId = service.Id,
                        ServiceName = service.ServiceName,
                        Unit = service.Unit,
                    };
                    result.Add(data);
                }
            }
            return result;
        }
    }
}
