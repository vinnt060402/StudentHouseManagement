/*using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking;
using StudentHouseMembershipCart.Application.Features.PaymentMethods;
using StudentHouseMembershipCart.Application.Features.PaymentMethods.Queries.GetAllPaymentMethod;
using StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.CreateReportWork;

namespace StudentHouseMembershipCart.API.Controllers.PaymentMethods
{
    [Route("api/v1/paymentmethods")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentMethodsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<List<PaymentMethodData>> GetAllPaymentMethodGroup()
        {
            var request = new GetAllPaymentMethodQueries();
            return await _mediator.Send(request);
        }
    }
}*/