using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetAllPaymentHistoryByAdmin
{
    public class GetAllPaymentHistoryByAdminQueryHandler : IRequestHandler<GetAllPaymentHistoryByAdminQuery, List<PaymentHistoryData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAllPaymentHistoryByAdminQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PaymentHistoryData>> Handle(GetAllPaymentHistoryByAdminQuery request, CancellationToken cancellationToken)
        {
            var paymentHistory = await _dbContext.PaymentHistory.ToListAsync();
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
}