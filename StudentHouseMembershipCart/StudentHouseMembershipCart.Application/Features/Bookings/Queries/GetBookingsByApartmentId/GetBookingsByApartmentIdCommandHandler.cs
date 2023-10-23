using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingsByApartmentId
{
    public class GetBookingsByApartmentIdCommandHandler : IRequestHandler<GetBookingsByApartmentIdCommand, List<BookingData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetBookingsByApartmentIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<BookingData>> Handle(GetBookingsByApartmentIdCommand request, CancellationToken cancellationToken)
        {
            var listBooking = await _dbContext.Booking.Where(x => x.ApartmentId == Guid.Parse(request.ApartmentId)).ToListAsync();
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
