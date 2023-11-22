/*using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByApartmentId;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByStudentId
{
    public class GetBookingByStudentIdCommandHandler : IRequestHandler<GetBookingByStudentIdCommand, List<BookingData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetBookingByStudentIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<BookingData>> Handle(GetBookingByStudentIdCommand request, CancellationToken cancellationToken)
        {
            var booking = await (from b in _dbContext.Booking
                                 join a in _dbContext.Apartment
                                 on b.ApartmentId equals a.Id
                                 where a.StudentId == request.StudentId
                                 select b).ToListAsync();

            List<BookingData> result = new List<BookingData>();
            if (!booking.Any())
            {
                throw new NotFoundException("This student do not booking before!");
            }
            foreach (var bookingData in booking)
            {
                var bd = _mapper.Map<BookingData>(bookingData);
                var bdd = await _dbContext.BookingDetail.Where(x => x.BookingId == bd.Id).ToListAsync();
                List<BookingDetailData> bookingDetailDatas = new List<BookingDetailData>();
                foreach (var item in bdd)
                {
                    var bddd = _mapper.Map<BookingDetailData>(item);
                    bookingDetailDatas.Add(bddd);
                }



                var apartmentIdRequest = new GetApartmentByApartmentIdQuery()
                {
                    ApartmentId = bookingData.ApartmentId
                };
                var apartmentResponse = await _mediator.Send(apartmentIdRequest);
                switch (bookingData.StatusContract)
                {
                    case 1:
                        bd.StatusContract = "Finished";
                        break;
                    case 0:
                        bd.StatusContract = "On Going";
                        break;
                    default:
                        bd.StatusContract = "Pending";
                        break;
                }
                bd.Details = bookingDetailDatas;
                bd.ApartmentData = apartmentResponse;
                result.Add(bd);
            }

            return result;
        }
    }
}*/