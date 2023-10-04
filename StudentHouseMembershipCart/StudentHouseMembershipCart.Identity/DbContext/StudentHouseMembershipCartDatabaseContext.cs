using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.IdentityModels;
using StudentHouseMembershipCart.Application.Common.Interfaces;

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
        public DbSet<BookingDetail> BookingDetail { get; set; }
        public DbSet<BookingDetailStaff> BookingDetailStaff { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<PackageService> PackageService { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<ReportWork> ReportWork { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }



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
                entry.Entity.LastModified = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Created = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
