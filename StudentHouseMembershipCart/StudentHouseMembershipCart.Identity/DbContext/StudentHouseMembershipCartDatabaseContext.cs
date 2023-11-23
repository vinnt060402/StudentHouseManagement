using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using StudentHouseMembershipCart.Identity.Services;

namespace StudentHouseMembershipCart.Identity.DbContext
{
    public class StudentHouseMembershipCartDatabaseContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public StudentHouseMembershipCartDatabaseContext(DbContextOptions<StudentHouseMembershipCartDatabaseContext> options) : base(options)
        {
        }

        public StudentHouseMembershipCartDatabaseContext()
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<AttendReport> AttendReport { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingDetailStaff> BookingDetailStaff { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<StaffCategory> StaffCategory { get; set; }
        public DbSet<PackageService> PackageService { get; set; }
        public DbSet<BookingDetailOfPakcage> BookingDetailOfPakcage { get; set; }
        public DbSet<BookingDetailOfService> BookingDetailOfService { get; set; }
        public DbSet<ServiceRemainingTaskDuration> ServiceRemainingTaskDuration { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<PaymentNew> PaymentNew { get; set; }
        public DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public DbSet<ReportWork> ReportWork { get; set; }
        public DbSet<Domain.Entities.Service> Service { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(StudentHouseMembershipCartDatabaseContext).Assembly);
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseAuditableEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Created = DateTime.Now;
                    entry.Entity.CreateBy = CustomSessionManager.GetString("username");
                }
                if (entry.State == EntityState.Modified || entry.State == EntityState.Deleted)
                {
                    entry.Entity.LastModified = DateTime.Now;
                    entry.Entity.LastModifiedBy = CustomSessionManager.GetString("username");
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
