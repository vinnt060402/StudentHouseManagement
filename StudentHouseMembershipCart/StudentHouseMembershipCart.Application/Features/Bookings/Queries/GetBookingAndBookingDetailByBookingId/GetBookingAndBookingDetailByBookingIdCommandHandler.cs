using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByTimeOfAdmin;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingAndBookingDetailByBookingId
{
    internal class GetBookingAndBookingDetailByBookingIdCommandHandler : IRequestHandler<GetBookingAndBookingDetailByBookingIdCommand, BookingData>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;
        private IMapper _mapper;

        public GetBookingAndBookingDetailByBookingIdCommandHandler(IApplicationDbContext dbContext, IMediator mediator, IMapper mapper)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<BookingData> Handle(GetBookingAndBookingDetailByBookingIdCommand request, CancellationToken cancellationToken)
        {
            var booking = await _dbContext.Booking.Where(x => x.Id == request.BookingId).SingleOrDefaultAsync();
            var bd = _mapper.Map<BookingData>(booking);
            if (booking == null)
            {
                throw new NotFoundException("Can not find this booking!"); 
            }
            var bookingDetail = await _dbContext.BookingDetail.Where(x => x.BookingId == request.BookingId).ToListAsync();
            List<BookingDetailData> Details = new List<BookingDetailData>();
            foreach (var item in bookingDetail)
            {
                var bdd = _mapper.Map<BookingDetailData>(item);
                Details.Add(bdd);
            }
            bd.Details =  Details;
            return bd;
        }
    }
}
