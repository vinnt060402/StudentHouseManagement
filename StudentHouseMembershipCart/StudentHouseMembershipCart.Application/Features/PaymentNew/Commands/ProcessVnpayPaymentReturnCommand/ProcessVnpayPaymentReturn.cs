using MediatR;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
using StudentHouseMembershipCart.VnPay.Response;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentReturnCommand
{
    public class ProcessVnpayPaymentReturn : VnpayPayResponse,
        IRequest<(PaymentReturnDto, string)>
    {

    }
}
