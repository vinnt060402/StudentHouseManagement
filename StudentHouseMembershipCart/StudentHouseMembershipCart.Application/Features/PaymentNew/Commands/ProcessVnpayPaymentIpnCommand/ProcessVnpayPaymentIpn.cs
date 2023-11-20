using MediatR;
using StudentHouseMembershipCart.Service.VnPay.Response;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentIpnCommand
{
    public class ProcessVnpayPaymentIpn : VnpayPayResponse,
        IRequest<VnpayPayIpnResponse>
    {
    }
}
