/*using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetFeedBackByFBID;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Queries;
using StudentHouseMembershipCart.Application.Features.SendMail;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Infrastucture.EmailService;

namespace StudentHouseMembershipCart.API.Controllers.Email
{
    [Route("api/v1/emails")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailServiceTest _email;
        private readonly IMediator _mediator;

        public EmailController(IEmailServiceTest email, IMediator mediator)
        {
            _email = email;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<SHMResponse> GetResponseSendMail([FromQuery] SendMailCommand request)
        {
            _email.SendSorryEmail(request);
            return await _mediator.Send(request);
        }
        [HttpGet]
        [Route("sendtostaff")]
        public async Task<SHMResponse> GetResponseSendMailToStaff([FromQuery] Guid staffId)
        {
            var request = new SendMailCommand()
            {
                Body = "a",
                Subject = "a",
                To = "a"
            };
            _email.SendEmailInfoStaffHavebeenAssign(staffId, "test", "test");
            return await _mediator.Send(request);
        }
    }
}
*/