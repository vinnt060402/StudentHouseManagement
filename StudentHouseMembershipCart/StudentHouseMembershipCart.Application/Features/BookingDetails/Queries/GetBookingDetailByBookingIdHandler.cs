/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries
{
    public class GetBookingDetailByBookingIdHandler : IRequestHandler<GetBookingDetailByBookingId, List<BookingDetailData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetBookingDetailByBookingIdHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<BookingDetailData>> Handle(GetBookingDetailByBookingId request, CancellationToken cancellationToken)
        {
            var bookingDetail = await _dbContext.BookingDetail.Where(x => x.BookingId == request.BookingId).ToListAsync();
            List<BookingDetailData> result = new List<BookingDetailData>();
            if (bookingDetail.Any())
            {
                foreach (var item in bookingDetail)
                {
                    var bdd = _mapper.Map<BookingDetailData>(item);
                    if (item.BookingDetailStatus == 0)
                    {
                        bdd.BookingDetailStatus = "On going";
                    }
                    else if (item.BookingDetailStatus == 1)
                    {
                        bdd.BookingDetailStatus = "Finished";
                    }
                    else
                    {
                        bdd.BookingDetailStatus = "Finished";
                    }
                    result.Add(bdd);
                }
            }
            return result;
        }
    }
}*/