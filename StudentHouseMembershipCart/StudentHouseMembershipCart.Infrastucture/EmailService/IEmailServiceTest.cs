using StudentHouseMembershipCart.Application.Features.SendMail;

namespace StudentHouseMembershipCart.Infrastucture.EmailService
{
    public interface IEmailServiceTest
    {
        void SendSorryEmail(SendMailCommand email);   
        void SendEmailInfoStaffHavebeenAssign(Guid StaffId, string staffName, string staffEmail);
        void SendEmailConfirmPaymentSuccessfully(string emailOfUser, string fullnameOfUser);
    }
}
