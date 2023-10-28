namespace StudentHouseMembershipCart.Application.Contracts.Logging
{
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string messsage, params object[] args);
    }
}
