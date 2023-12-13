using MediatR;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Queries.GetPaymentQuery
{
    public class GetPaymentRequest : IRequest<PaymentDto>
    {
        public string Id { get; set; } = string.Empty;
    }
}
