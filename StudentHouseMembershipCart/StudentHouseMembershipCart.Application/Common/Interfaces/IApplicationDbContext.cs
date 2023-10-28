using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<AttendReport> AttendReport { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingDetail> BookingDetail { get; set; }
        public DbSet<BookingDetailStaff> BookingDetailStaff { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<StaffCategory> StaffCategory {  get; set; }
        public DbSet<PackageService> PackageService { get; set; }
        public DbSet<PaymentHistory> PaymentHistory { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<ReportWork> ReportWork { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
