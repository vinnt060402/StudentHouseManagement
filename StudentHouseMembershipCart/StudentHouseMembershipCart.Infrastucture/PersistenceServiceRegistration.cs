using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentHouseMembershipCartDatabaseContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("StudentHouseMembershipCart"));
            });
            return services;
        }
    }
}
