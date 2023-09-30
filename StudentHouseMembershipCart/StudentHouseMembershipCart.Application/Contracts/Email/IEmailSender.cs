using StudentHouseMembershipCart.Application.Models.Email.EmailMessage;

namespace StudentHouseMembershipCart.Application.Contracts.Email
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(EmailMessage email);
    }
}
