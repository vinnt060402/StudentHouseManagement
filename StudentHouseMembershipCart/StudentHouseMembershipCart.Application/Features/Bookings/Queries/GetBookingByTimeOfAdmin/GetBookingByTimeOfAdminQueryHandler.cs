using MediatR;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByTimeOfAdmin
{
    public class GetBookingByTimeOfAdminQueryHandler : IRequestHandler<GetBookingByTimeOfAdminQuery, BookingDataForAdmin>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public GetBookingByTimeOfAdminQueryHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<BookingDataForAdmin> Handle(GetBookingByTimeOfAdminQuery request, CancellationToken cancellationToken)
        {
            var getListBookingData = new GetAllBookingCommand();
            var listBookingData = await _mediator.Send(getListBookingData);
            listBookingData = listBookingData.Where(x => request.StartDate.HasValue ? /*(x.Created >= request.StartDate*/DateTime.Compare(x.Created, request.StartDate ?? DateTime.Now) >= 0 : true &&
                                                         request.EndDate.HasValue ? DateTime.Compare(x.Created, request.EndDate ?? DateTime.Now) <= 0 : true).ToList();
            var totalPrice = listBookingData.Select(x => x.TotalPay).Sum();
            BookingDataForAdmin response = new BookingDataForAdmin
            {
                ListBookingData = listBookingData,
                TotalPrice = totalPrice,
            };
            return response;
        }
    }
}