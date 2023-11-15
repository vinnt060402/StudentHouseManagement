/*using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Commands.UpdatePaymentHistory
{
    public class UpdatePaymentHistoryCommandHandler : IRequestHandler<UpdatePaymentHistoryCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdatePaymentHistoryCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdatePaymentHistoryCommand request, CancellationToken cancellationToken)
        {

            var pH = await _dbContext.PaymentHistory.Where(x => x.Id == request.PaymentHistoryId).SingleOrDefaultAsync();
            if (pH == null)
            {
                throw new NotFoundException("Not found this PaymentHistory!!");
            }
            pH.PaymentStatus = request.PaymentHistoryStatus;
            _dbContext.PaymentHistory.Update(pH);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}
*/