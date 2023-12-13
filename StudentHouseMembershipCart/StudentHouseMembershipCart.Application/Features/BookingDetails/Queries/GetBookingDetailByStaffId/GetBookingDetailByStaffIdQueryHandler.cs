/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailByStaffId
{
    public class GetBookingDetailByStaffIdQueryHandler : IRequestHandler<GetBookingDetailByStaffIdQuery, List<BookingDetailByStaffIdModel>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetBookingDetailByStaffIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<BookingDetailByStaffIdModel>> Handle(GetBookingDetailByStaffIdQuery request, CancellationToken cancellationToken)
        {
            var listBookingDetailIdByStaffId = await _dbContext.BookingDetailStaff.Where(x => x.StaffId == Guid.Parse(request.StaffId)).Select(x => x.BookingDetailId).ToListAsync();
            if (!listBookingDetailIdByStaffId.Any())
            {
                throw new NotFoundException("Do not assign task for this staff before!!");
            }
            var listData = new List<BookingDetailByStaffIdModel>();
            foreach (var item in listBookingDetailIdByStaffId)
            {
                var data = await _dbContext.BookingDetail.Where(x => x.Id == item).FirstOrDefaultAsync();
                if (data != null)
                {
                    var bdd = _mapper.Map<BookingDetailData>(data);
                    var bookingDetailByStaffIdModel = new BookingDetailByStaffIdModel
                    {
                        BookingDetailData = bdd
                    };
                    listData.Add(bookingDetailByStaffIdModel);
                }
            }
            return listData;
        }
    }
}*/