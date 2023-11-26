using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentHouseMembershipCart.Application.Contracts.Email;
using StudentHouseMembershipCart.Application.Contracts.Logging;
using StudentHouseMembershipCart.Application.Models.Email.EmailMessage;
using StudentHouseMembershipCart.Infrastucture.EmailService;
using StudentHouseMembershipCart.Infrastucture.Logging;

namespace StudentHouseMembershipCart.Infrastucture
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection
            services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.Configure<EmailSenderTest>(configuration.GetSection("EmailSenderTest"));
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IEmailServiceTest, EmailServiceTest>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            return services;
        }
    }
}
