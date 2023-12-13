/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetPaymentHistoryByApartmentIdOfCustomer
{
    public class GetPaymentHistoryByApartmentIdOfCustomerQueryHandler : IRequestHandler<GetPaymentHistoryByApartmentIdOfCustomerQuery, List<PaymentHistoryData>>
    {
        private IApplicationDbContext _dbContext { get; set; }
        private IMapper _mapper { get; set; }

        public GetPaymentHistoryByApartmentIdOfCustomerQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PaymentHistoryData>> Handle(GetPaymentHistoryByApartmentIdOfCustomerQuery request, CancellationToken cancellationToken)
        {
            var paymentHistory = await (from pH in _dbContext.PaymentHistory

                                        join b in _dbContext.Booking
                                        on pH.BookingId equals b.Id

                                        where b.ApartmentId == request.ApartmentId
                                        select pH
                                  ).ToListAsync();
            List<PaymentHistoryData> response = new List<PaymentHistoryData>();

            if (paymentHistory.Any())
            {
                foreach (var paymentHistoryData in paymentHistory)
                {
                    var data = _mapper.Map<PaymentHistoryData>(paymentHistoryData);
                    response.Add(data);
                }
            }
            return response;
        }
    }
}*/