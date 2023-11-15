using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Commands.CreatePaymentHistory
{
    public class CreatePaymentHistoryCommand : IRequest<SHMResponse>
    {
        public Guid PaymentMethodId { get; set; }
        public Guid BookingId { get; set; }
        public double Amount { get; set; }
        public int PaymentStatus { get; set; }
        public string? CreateBy { get; set; }
    }
}