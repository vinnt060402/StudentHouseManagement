using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking
{
    public class GetAllBookingCommandHandler : IRequestHandler<GetAllBookingCommand, List<BookingData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAllBookingCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<BookingData>> Handle(GetAllBookingCommand request, CancellationToken cancellationToken)
        {
            var listBooking = await _dbContext.Booking.OrderBy(x => x.Created).ToListAsync();
            List<BookingData> result = new List<BookingData>();
            foreach (var booking in listBooking)
            {
                var bookingResult = _mapper.Map<BookingData>(booking);
                switch (booking.StatusContract)
                {
                    case 1:
                        bookingResult.StatusContract = "Finished";
                        break;
                    case 0:
                        bookingResult.StatusContract = "On Going";
                        break;
                    default:
                        bookingResult.StatusContract = "Pending";
                        break;
                }
                result.Add(bookingResult);
            }
            return result;
        }
    }
}
