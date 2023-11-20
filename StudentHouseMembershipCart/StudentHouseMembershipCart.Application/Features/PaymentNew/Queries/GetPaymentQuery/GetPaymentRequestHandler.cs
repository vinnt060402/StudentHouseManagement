using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Queries.GetPaymentQuery
{
    public class GetPaymentRequestHandler : IRequestHandler<GetPaymentRequest, PaymentDto>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetPaymentRequestHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PaymentDto> Handle(GetPaymentRequest request, CancellationToken cancellationToken)
        {
            var payment = await _dbContext.PaymentNew.Where(x => x.PaymentNewId == request.Id).FirstOrDefaultAsync();
            if(payment == null)
            {
                throw new NotFoundException("Not found!");
            }

            var result = _mapper.Map<PaymentDto>(payment);  
            return result;
            throw new NotImplementedException();
        }
    }
}
