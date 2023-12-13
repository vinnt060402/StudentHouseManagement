using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentHouseMembershipCart.API.Service;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.CreatePaymentCommand;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentReturnCommand;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByApartmentId;
using StudentHouseMembershipCart.Application.Models.Email.EmailMessage;
using StudentHouseMembershipCart.Infrastucture.EmailService;
using StudentHouseMembershipCart.Ultils.Extensions;
using StudentHouseMembershipCart.VnPay.Response;

namespace StudentHouseMembershipCart.API.Controllers.Payment
{
    [Route("api/v1/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private IMediator _mediator;
        private IEmailServiceTest _email;

        public PaymentController(IMediator mediator,IEmailServiceTest email)
        {
            _mediator = mediator;
            _email = email;
        }

        [HttpPost]
        public async Task<PaymentLinkDto> CreatePaymentLink(CreatePaymentRequest request)
        {
            var response = await _mediator.Send(request);
            var createBooking = new CreateNewBookingCommand()
            {
                ApartmentId = request.NewBooking.ApartmentId,
                StartDate = request.NewBooking.StartDate,
                EndDate = request.NewBooking.EndDate,
                ListPackage = request.NewBooking.ListPackage,
                ListService = request.NewBooking.ListService,
                TotalPrice = request.NewBooking.TotalPrice,
                PaymentNew = response.PaymentId!
            };
            await _mediator.Send(createBooking);
            return response;
        }
        [HttpGet]
        [Route("vnpay-return")]
        public async Task<IActionResult> GetPaymentLink([FromQuery] VnpayPayResponse response)
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

            try
            {
                if(returnModel.PaymentStatus == "00")
                {
                    var studentData = await _mediator.Send(new GetStudentByApartmentIdQuery()
                    {
                        PaymentnewId = returnModel.PaymentId!
                    });
                    _email.SendEmailConfirmPaymentSuccessfully(studentData.ApplicationUserData.Email!, studentData.ApplicationUserData.FullName!);
                }
                return Redirect($"{returnUrl}?{returnModel.ToQueryString()}");
            }
            catch
            {
                return Redirect($"{returnUrl}?{returnModel.ToQueryString()}");
            }

        }
    }
}
