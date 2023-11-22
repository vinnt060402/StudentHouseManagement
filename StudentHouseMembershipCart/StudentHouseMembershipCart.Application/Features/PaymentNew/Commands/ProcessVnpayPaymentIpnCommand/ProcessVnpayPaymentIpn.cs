using MediatR;
using StudentHouseMembershipCart.VnPay.Response;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentIpnCommand
{
    public class ProcessVnpayPaymentIpn : VnpayPayResponse,
        IRequest<VnpayPayIpnResponse>
    {
    }
}
