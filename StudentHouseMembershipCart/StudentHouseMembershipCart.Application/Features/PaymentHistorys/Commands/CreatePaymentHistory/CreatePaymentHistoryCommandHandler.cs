using MediatR;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Commands.CreatePaymentHistory
{
    public class CreatePaymentHistoryCommandHandler : IRequestHandler<CreatePaymentHistoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreatePaymentHistoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreatePaymentHistoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var paymentHistory = new PaymentHistory
                {
                    PaymentMethodId = request.PaymentMethodId,
                    BookingId = request.BookingId,
                    Amount = request.Amount,
                    PaymentStatus = request.PaymentStatus,
                    CreateBy = request.CreateBy,
                };
                _dbContext.PaymentHistory.Add(paymentHistory);
                await _dbContext.SaveChangesAsync();
                Task.WaitAll();
                return new SHMResponse
                {
                    Message = Extensions.CreateSuccessfully
                };
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}