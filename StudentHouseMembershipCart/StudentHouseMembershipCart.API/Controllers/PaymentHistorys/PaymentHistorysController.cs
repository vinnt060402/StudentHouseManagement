/*using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Commands.UpdatePaymentHistory;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetAllPaymentHistoryByAdmin;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetPaymentHistoryByApartmentIdOfCustomer;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetPaymentHistoryByCustomerIdOfCustomer;

namespace StudentHouseMembershipCart.API.Controllers.PaymentHistorys
{
    [Route("api/v1/paymenthistorys")]
    [ApiController]
    public class PaymentHistorysController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentHistorysController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<PaymentHistoryData>> GetAllPaymentHistory()
        {
            var request = new GetAllPaymentHistoryByAdminQuery();
            return await _mediator.Send(request);
        }
        [HttpGet]
        [Route("apartmentid")]
        public async Task<List<PaymentHistoryData>> GetPaymentHistoryByApartmentId([FromQuery] GetPaymentHistoryByApartmentIdOfCustomerQuery request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [Route("studentid")]
        public async Task<List<PaymentHistoryData>> GetPaymentHistoryByStudentId([FromQuery] GetPaymentHistoryByCustomerIdOfCustomerCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> UpdatePaymentHistoryStatus(UpdatePaymentHistoryCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}*/