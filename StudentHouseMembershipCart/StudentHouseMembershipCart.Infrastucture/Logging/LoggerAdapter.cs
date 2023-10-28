using Microsoft.Extensions.Logging;
using StudentHouseMembershipCart.Application.Contracts.Logging;

namespace StudentHouseMembershipCart.Infrastucture.Logging
{
    public class LoggerAdapter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> _logger;
        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }
        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public void LogWarning(string messsage, params object[] args)
        {
            _logger.LogWarning(messsage, args);
        }
    }
}
