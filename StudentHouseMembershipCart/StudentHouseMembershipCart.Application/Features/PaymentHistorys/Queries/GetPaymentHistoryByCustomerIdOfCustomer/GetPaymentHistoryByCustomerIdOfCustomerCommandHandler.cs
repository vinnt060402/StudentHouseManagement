/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetPaymentHistoryByCustomerIdOfCustomer
{
    public class GetPaymentHistoryByCustomerIdOfCustomerCommandHandler : IRequestHandler<GetPaymentHistoryByCustomerIdOfCustomerCommand, List<PaymentHistoryData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetPaymentHistoryByCustomerIdOfCustomerCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PaymentHistoryData>> Handle(GetPaymentHistoryByCustomerIdOfCustomerCommand request, CancellationToken cancellationToken)
        {
            var paymentHistory = await (from pH in _dbContext.PaymentHistory

                                        join b in _dbContext.Booking
                                        on pH.BookingId equals b.Id

                                        join aP in _dbContext.Apartment
                                        on b.ApartmentId equals aP.Id

                                        join s in _dbContext.Student
                                        on aP.StudentId equals s.Id

                                        where s.Id == request.StudentId

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