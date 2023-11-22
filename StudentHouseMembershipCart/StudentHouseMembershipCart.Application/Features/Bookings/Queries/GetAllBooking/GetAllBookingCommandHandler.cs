/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByApartmentId;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking
{
    public class GetAllBookingCommandHandler : IRequestHandler<GetAllBookingCommand, List<BookingData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetAllBookingCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<BookingData>> Handle(GetAllBookingCommand request, CancellationToken cancellationToken)
        {
            var listBooking = await _dbContext.Booking.OrderBy(x => x.Created).ToListAsync();

            List<BookingData> result = new List<BookingData>();
            foreach (var booking in listBooking)
            {
                var bookingResult = _mapper.Map<BookingData>(booking);
                var student = await (from st in _dbContext.Student
                                     join ap in _dbContext.Apartment
                                     on st.Id equals ap.StudentId
                                     where ap.Id == bookingResult.ApartmentId
                                     select st).SingleOrDefaultAsync();
                if (student != null)
                {
                    var getstRequest = new GetStudentByStudentIdCommand
                    {
                        StudentId = student.Id,
                    };
                    var getstReponse = await _mediator.Send(getstRequest);
                    bookingResult.StudentName = getstReponse.ApplicationUserData.FullName;
                }
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
                var bookingdetailrequest = new GetBookingDetailByBookingId
                {
                    BookingId = booking.Id,
                };
                var bddResponse = await _mediator.Send(bookingdetailrequest);
                var apartmentIdRequest = new GetApartmentByApartmentIdQuery()
                {
                    ApartmentId = booking.ApartmentId
                };
                var apartmentResponse = await _mediator.Send(apartmentIdRequest);
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
                var bookingPaymentHistory = _dbContext.PaymentHistory.Where(x => x.BookingId == booking.Id).FirstOrDefault();
                if (bookingPaymentHistory != null)
                {
                    bookingResult.PaymentMethodName = _dbContext.PaymentMethod.Where(x => x.Id == bookingPaymentHistory.PaymentMethodId).Select(x => x.PaymentMethodName).FirstOrDefault() ?? null;
                }
                else
                {
                    bookingResult.PaymentMethodName = null;
                }
                bookingResult.ApartmentData = apartmentResponse;
                bookingResult.Details = bddResponse;

                result.Add(bookingResult);
            }
            return result;
        }
    }
}*/