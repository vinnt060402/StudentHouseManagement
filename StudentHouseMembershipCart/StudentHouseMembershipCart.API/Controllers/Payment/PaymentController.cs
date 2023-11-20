using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.CreatePaymentCommand;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentIpnCommand;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentReturnCommand;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
using StudentHouseMembershipCart.Service.VnPay.Response;
using StudentHouseMembershipCart.Ultils.Extensions;

namespace StudentHouseMembershipCart.API.Controllers.Payment
{
    [Route("api/v1/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private IMediator _mediator;

        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<PaymentLinkDto> CreatePaymentLink(CreatePaymentRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
        [HttpGet]
        [Route("vnpay-return")]
        public async Task<IActionResult> GetPaymentLink([FromQuery]VnpayPayResponse response)
        {
            string returnUrl = string.Empty;
            var returnModel = new PaymentReturnDto();
            var processResult = await _mediator.Send(response.Adapt<ProcessVnpayPaymentReturn>());
            if (!processResult.Item2.IsNullOrEmpty())
            {
                returnModel = processResult.Item1 as PaymentReturnDto;
                returnUrl = processResult.Item2 as string;
            }

            if (returnUrl.EndsWith("/"))
                returnUrl = returnUrl.Remove(returnUrl.Length - 1, 1);
            return Redirect($"{returnUrl}?{returnModel.ToQueryString()}");
        }
    }
}
