using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByApartmentId;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingsByApartmentId
{
    public class GetBookingsByApartmentIdCommandHandler : IRequestHandler<GetBookingsByApartmentIdCommand, List<BookingData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetBookingsByApartmentIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<BookingData>> Handle(GetBookingsByApartmentIdCommand request, CancellationToken cancellationToken)
        {
            var listBooking = await _dbContext.Booking.Where(x => x.ApartmentId == Guid.Parse(request.ApartmentId)).ToListAsync();
            List<BookingData> result = new List<BookingData>();
            foreach (var booking in listBooking)
            {


                var apartmentIdRequest = new GetApartmentByApartmentIdQuery()
                {
                    ApartmentId = booking.ApartmentId
                };
                var apartmentResponse = await _mediator.Send(apartmentIdRequest);

                var bookingResult = _mapper.Map<BookingData>(booking);
                bookingResult.ApartmentData = apartmentResponse;
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