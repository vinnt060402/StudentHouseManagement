using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Apartments;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByApartmentId;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBooking
{
    public class GetAllBookingNewCommandHandler : IRequestHandler<GetAllBookingNewCommand, List<BookingDataNew>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetAllBookingNewCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<BookingDataNew>> Handle(GetAllBookingNewCommand request, CancellationToken cancellationToken)
        {
            var bookingList = await _dbContext.Booking
                                                .Where(b => !b.IsDelete)
                                                .OrderBy(x => x.Created)
                                                .ToListAsync();

            var result = new List<BookingDataNew>();


            foreach (var booking in bookingList) {
                var apartment = await _dbContext.Apartment
                    .FirstOrDefaultAsync(a => a.Id == booking.ApartmentId && !a.IsDelete);

                if (apartment != null) {
                    var studentName = await GetStudentName(apartment.Id);
                    var statusContract = StatusContract(booking.StatusContract);

                    var bookingData = new BookingDataNew
                    {
                        Id = booking.Id,
                        StudentName = studentName,
                        TotalPay = booking.TotalPay,
                        ApartmentId = apartment.Id,
                        ApartmentData = _mapper.Map<ApartmentDto>(apartment),
                        StatusContract = statusContract,
                        Created = booking.Created,
                    };

                    result.Add(bookingData);
                }
            }

            return result;
        }

        private async Task<string> GetStudentName(Guid apartmentId)
        {
            try {
                var studentExist = await _dbContext.Apartment.Where(a => !a.IsDelete && a.Id == apartmentId).Select(a => a.StudentId).SingleOrDefaultAsync();
                var applicationUserExist = await _dbContext.Student.Where(s => !s.IsDelete && s.Id == studentExist).Select(s => s.ApplicationUserId).SingleOrDefaultAsync();
                var studentNameExist = await _dbContext.ApplicationUsers.Where(s => s.Id == applicationUserExist).Select(s => s.FullName).SingleOrDefaultAsync();

                return studentNameExist;
            }
            catch(Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        private string StatusContract(int? status)
        {
            switch (status) {
                case 1:
                    return "Finished";
                case 0:
                    return "On Going";
                default:
                    return "Pending";
            }
        }
    }
}