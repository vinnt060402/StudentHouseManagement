using MediatR;
using Microsoft.AspNetCore.Http;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.CreatePaymentCommand
{
    public class CreatePaymentWithHttpRequest : IRequest<PaymentLinkDto>
    {
        public string PaymentContent { get; set; } = string.Empty;
        public string PaymentCurrency { get; set; } = string.Empty;
        public string PaymentRefId { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; }
        public string? Signature { get; set; }
        public string? PaymentDestinationId { get; set; } = string.Empty;
        public HttpContext Context { get; set; } = null!;
    }
}
