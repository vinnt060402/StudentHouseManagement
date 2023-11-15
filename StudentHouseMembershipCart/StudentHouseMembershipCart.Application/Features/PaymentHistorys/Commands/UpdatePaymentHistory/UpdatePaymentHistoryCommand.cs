using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Commands.UpdatePaymentHistory
{
    public class UpdatePaymentHistoryCommand : IRequest<SHMResponse>
    {
        public Guid PaymentHistoryId { get; set; }
        public int PaymentHistoryStatus { get; set; }
    }
}