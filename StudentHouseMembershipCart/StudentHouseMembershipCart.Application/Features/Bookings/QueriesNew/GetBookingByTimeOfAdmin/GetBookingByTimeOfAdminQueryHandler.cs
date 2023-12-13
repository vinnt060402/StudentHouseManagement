using MediatR;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByTimeOfAdmin;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBooking;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByTimeOfAdmin
{
    public class GetBookingByTimeOfAdminNewQueryHandler : IRequestHandler<GetBookingByTimeOfAdminNewQuery, BookingDataForAdminNew>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public GetBookingByTimeOfAdminNewQueryHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<BookingDataForAdminNew> Handle(GetBookingByTimeOfAdminNewQuery request, CancellationToken cancellationToken)
        {
            var getListBookingData = new GetAllBookingNewCommand();
            var listBookingData = await _mediator.Send(getListBookingData);
            listBookingData = listBookingData.Where(x => request.StartDate.HasValue ? /*(x.Created >= request.StartDate*/DateTime.Compare(x.Created, request.StartDate ?? DateTime.Now) >= 0 : true &&
                                                         request.EndDate.HasValue ? DateTime.Compare(x.Created, request.EndDate ?? DateTime.Now) <= 0 : true).ToList();
            var totalPrice = listBookingData.Select(x => x.TotalPay).Sum();
            BookingDataForAdminNew response = new BookingDataForAdminNew
            {
                ListBookingDataNew = listBookingData,
                TotalPrice = totalPrice,
            };
            return response;
        }
    }
}