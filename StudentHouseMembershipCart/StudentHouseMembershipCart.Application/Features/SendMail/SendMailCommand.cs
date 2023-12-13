using MailKit.Net.Smtp;
using MediatR;
using Microsoft.Extensions.Options;
using MimeKit;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Contracts.Email;
using StudentHouseMembershipCart.Application.Models.Email.EmailMessage;

namespace StudentHouseMembershipCart.Application.Features.SendMail
{
    public class SendMailCommand : IRequest<SHMResponse>
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
    public class SendMailCommandHanlder : IRequestHandler<SendMailCommand, SHMResponse>
    {
        private IEmailSender emailSender;
        private EmailSenderTest _emailSenderTes { get; set; }

        public SendMailCommandHanlder(IEmailSender emailSender, IOptions<EmailSenderTest> emailSenderTes)
        {
            this.emailSender = emailSender;
            _emailSenderTes = emailSenderTes.Value;
        }

        public async Task<SHMResponse> Handle(SendMailCommand request, CancellationToken cancellationToken)
        {
            try
            {

                return new SHMResponse
                {
                    Message = "Send Thanh Cong"
                };
            }
            catch (Exception ex)
            {
                return new SHMResponse
                {
                    Message = "Oh no"
                };
            }
        }
    }
}
