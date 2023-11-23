using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<AttendReport> AttendReport { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingDetailStaff> BookingDetailStaff { get; set; }
        public DbSet<BookingDetailOfPakcage> BookingDetailOfPakcage { get; set; }
        public DbSet<BookingDetailOfService> BookingDetailOfService { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<StaffCategory> StaffCategory {  get; set; }
        public DbSet<PackageService> PackageService { get; set; }
        public DbSet<PaymentNew> PaymentNew { get; set; }
        public DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public DbSet<ServiceRemainingTaskDuration> ServiceRemainingTaskDuration { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<ReportWork> ReportWork { get; set; }
        public DbSet<Domain.Entities.Service> Service { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
