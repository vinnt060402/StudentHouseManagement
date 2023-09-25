using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;
using StudentHouseMembershipCart.Infrastucture.Repositories;

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

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IAttendReportRepository, AttendReportRepository>();
            services.AddScoped<IBookingDetailRepository, BookingDetailRepository>();
            services.AddScoped<IBookingDetailStaffRepository, BookingDetailStaffRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFeedBackRepository, FeedBackRepository>();
            services.AddScoped<IPackageRepository, PackageRepository>();
            services.AddScoped<IPackageServiceRepository, PackageServiceRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IReportWorkRepository, ReportWorkeRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
