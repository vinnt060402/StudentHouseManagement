/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.PaymentMethods.Queries.GetAllPaymentMethod
{
    public class GetAllPaymentMethodQueriesHandler : IRequestHandler<GetAllPaymentMethodQueries, List<PaymentMethodData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetAllPaymentMethodQueriesHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PaymentMethodData>> Handle(GetAllPaymentMethodQueries request, CancellationToken cancellationToken)
        {
            var paymentMethod = await _dbContext.PaymentMethod.ToListAsync();
            List<PaymentMethodData> response = new List<PaymentMethodData>();
            foreach (var item in paymentMethod)
            {
                var data = _mapper.Map<PaymentMethodData>(item);
                response.Add(data);
            }
            return response;
        }
    }
}*/