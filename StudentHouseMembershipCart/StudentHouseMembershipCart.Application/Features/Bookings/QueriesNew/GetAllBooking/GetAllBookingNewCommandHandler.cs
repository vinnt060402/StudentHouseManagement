using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var bookingList = await _dbContext.Booking.Where(b => !b.IsDelete)
                                                .Join(
                                                    _dbContext.Apartment,
                                                    booking => booking.ApartmentId,
                                                    apartment => apartment.Id,
                                                    (booking, apartment) => new BookingDataNew
                                                    {
                                                        Id = booking.Id,
                                                        StudentName = StudentName(apartment.Id),
                                                        TotalPay = booking.TotalPay,
                                                        ApartmentId = apartment.Id,
                                                        ApartmentData = _mapper.Map<ApartmentDto>(apartment),
                                                        StatusContract = StatusContract(booking.StatusContract),
                                                        Created = booking.Created,
                                                    }
                                                )
                                                .OrderBy(x => x.Created).ToListAsync();
            
            

            var data = _mapper.Map<List<BookingDataNew>>(bookingList);

            return data;
        }

        private string StudentName(Guid apartmentId)
        {
            var studentExist = _dbContext.Apartment.Where(a => !a.IsDelete && a.Id == apartmentId).Select(a => a.StudentId).SingleOrDefault();
            var applicationUserExist = _dbContext.Student.Where(s => !s.IsDelete && s.Id == studentExist).Select(s => s.ApplicationUserId).SingleOrDefault();
            var studentNameExist = _dbContext.ApplicationUsers.Where(s => s.Id == applicationUserExist).Select(s => s.FullName).SingleOrDefault();

            return studentNameExist;
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