using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.Ocsp;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.SendMail;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff;
using StudentHouseMembershipCart.Application.Models.Email.EmailMessage;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.Net;
using System.Net.Mail;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StudentHouseMembershipCart.Infrastucture.EmailService
{
    public class EmailServiceTest : IEmailServiceTest
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;
        private readonly UserManager<ApplicationUser> _userManager;
        private EmailSenderTest _emailSenderTes { get; set; }

        /*        public EmailServiceTest(
                    IMediator mediator,
                    UserManager<ApplicationUser> userManager, IApplicationDbContext dbContext, IOptions<EmailSenderTest> emailSenderTes)
                {
                    this._mediator = mediator;
                    this._userManager = userManager;
                    _dbContext = dbContext;
                    _emailSenderTes = emailSenderTes.Value;
                }*/

        public EmailServiceTest(IApplicationDbContext dbContext, IMediator mediator, UserManager<ApplicationUser> userManager, IOptions<EmailSenderTest> emailSenderTes)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _userManager = userManager;
            _emailSenderTes = emailSenderTes.Value;
        }

        public void SendSorryEmail(SendMailCommand request)
        {
            var sorry = @"<body style=""background-color: #f8f8f8; color: #333; text-align: center; padding: 20px;"">
                             <h1 style=""color: #cc0000;"">We Apologize for the Inconvenience!</h1>
                             <p style=""margin: 15px 0;"">Regrettably, we couldn't find a suitable staff member for your scheduled appointment.</p>
                             <p style=""margin: 15px 0;"">We kindly request you to cancel your existing appointment and reschedule a new one so that we can provide you with the best assistance.</p>
                             <p style=""margin: 15px 0;"">Thank you for your understanding, and we look forward to serving you at the earliest convenience!</p>
                            <!-- Add section for creating a new appointment here -->
                            <a href=""https://services4s.vercel.app/"" style=""display: inline-block; padding: 10px 20px; background-color: #0066cc; color: #fff; text-decoration: none; border-radius: 5px;"">Visit Our Web To Create New Attend Report</a>
                          </body>";
            var emailNew = new MailMessage();
            string fromMail = _emailSenderTes.Username;
            string fromPassword = _emailSenderTes.Password;
            emailNew.From = new MailAddress(fromMail);
            emailNew.Subject = request.Subject;
            emailNew.To.Add(new MailAddress(request.To));
            emailNew.Body = sorry;
            emailNew.IsBodyHtml = true;

            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };

            smtp.SendMailAsync(emailNew);
        }
        public async void SendEmailInfoStaffHavebeenAssign(Guid StaffId, string staffName, string staffEmail)
        {
            var aId = _dbContext.Staff.Where(x => x.Id == StaffId).SingleOrDefault();
            if (aId != null)
            {
                /*                var getStaff = await _mediator.Send(new GetStaffQuery()
                                {
                                    Id = aId.Id,
                                });*/
                //var emailOfStaff = await _userManager.FindByIdAsync(aId.ApplicationUserId);
                if (true)
                {
                    var body = @"<body style=""background-color: #f8f8f8; color: #333; text-align: center; padding: 20px;"">
    <h1 style=""color: #0066cc;"">New Task Assigned!</h1>
    <p style=""margin: 15px 0;"">Dear [Staff Name],</p>
    <p style=""margin: 15px 0;"">You have been assigned a new task by the Administrator. Please log in to our website to view the latest updated task details:</p>
    <a href=""https://services4s.vercel.app/"" style=""display: inline-block; padding: 10px 20px; background-color: #cc0000; color: #fff; text-decoration: none; border-radius: 5px;"">Log In and View Task</a>
    <p style=""margin: 15px 0;"">Thank you for your attention to this matter. We appreciate your prompt action.</p>
    <p style=""margin: 15px 0;"">Best Regards,<br> The [Your Company Name] Team</p>
</body>";
                    body = body.Replace("[Staff Name]", staffName);

                    var emailNew = new MailMessage();
                    string fromMail = _emailSenderTes.Username;
                    string companyName = _emailSenderTes.CompanyName;
                    string fromPassword = _emailSenderTes.Password;

                    body = body.Replace("[Your Company Name]", companyName);
                    emailNew.From = new MailAddress("no-reply@gmail.com");
                    emailNew.Subject = "New Task Assignment";
                    emailNew.To.Add(new MailAddress(staffEmail));
                    emailNew.Body = body;
                    emailNew.IsBodyHtml = true;

                    var smtp = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromMail, fromPassword),
                        EnableSsl = true
                    };

                    await smtp.SendMailAsync(emailNew);
                }
            }
        }
        public async void SendEmailConfirmPaymentSuccessfully(string emailOfUser, string fullnameOfUser)
        {
            var body = @"<body style=""background-color: #f8f8f8; color: #333; text-align: center; padding: 20px; font-family: 'Arial', sans-serif;"">
                         <h1 style=""color: #0066cc;"">Payment Successful!</h1>
    <p style=""margin: 15px 0;"">Dear [User Name],</p>
    <p style=""margin: 15px 0;"">We deeply appreciate your trust in our services, and we're delighted to inform you that your recent payment for an order has been successfully processed.</p>
    <p style=""margin: 15px 0;"">Thank you for choosing [Your Company Name]. Your support is invaluable to us, and we strive to ensure your experience with our services is nothing short of exceptional.</p>
    <p style=""margin: 15px 0;"">If you have any questions regarding your order or need further assistance, please feel free to contact our customer support team.</p>
    <p style=""margin: 15px 0;"">Once again, thank you for your business. Wishing you a fantastic experience with our products and services!</p>
    <p style=""margin: 15px 0;"">Best Regards,<br> The [Your Company Name] Team</p>
</body>";
            var emailNew = new MailMessage();
            string fromMail = _emailSenderTes.Username;
            string companyName = _emailSenderTes.CompanyName;
            string fromPassword = _emailSenderTes.Password;

            body = body.Replace("[Your Company Name]", companyName);
            body = body.Replace("[User Name]", fullnameOfUser);
            emailNew.From = new MailAddress("no-reply@gmail.com");
            emailNew.Subject = "New Task Assignment";
            emailNew.To.Add(new MailAddress(emailOfUser));
            emailNew.Body = body;
            emailNew.IsBodyHtml = true;

            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };

            await smtp.SendMailAsync(emailNew);
        }
    }
}
