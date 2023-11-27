using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Identity.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "ACCOUNT1",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    FullName = "Admin",
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    PasswordHash = hasher.HashPassword(null, "1"),
                    EmailConfirmed = true,
                }/*,
                new ApplicationUser
                {
                    Id = "ACCOUNT2",
                    Email = "vinntse160956@gmail.com",
                    NormalizedEmail = "VINNTSE160956@GMAIL.COM",
                    FullName = "Nguyễn Ngọc Thái Vĩ",
                    UserName = "vinntse160956",
                    NormalizedUserName = "VINNTSE160956",
                    PasswordHash = hasher.HashPassword(null, "1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT3",
                    Email = "dai@gmail.com",
                    NormalizedEmail = "DAI@GMAIL.COM",
                    FullName = "Nguyen Dai",
                    UserName = "dai@gmail.com",
                    NormalizedUserName = "DAI@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT4",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    FullName = "admin",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT5",
                    Email = "staff1@gmail.com",
                    NormalizedEmail = "STAFF1@GMAIL.COM",
                    FullName = "staff",
                    UserName = "staff",
                    NormalizedUserName = "STAFF",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT6",
                    Email = "staff2@gmail.com",
                    NormalizedEmail = "STAFF2@GMAIL.COM",
                    FullName = "staff2",
                    UserName = "staff2",
                    NormalizedUserName = "STAFF2",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT7",
                    Email = "staff3@gmail.com",
                    NormalizedEmail = "STAFF3@GMAIL.COM",
                    FullName = "staff3",
                    UserName = "staff3",
                    NormalizedUserName = "STAFF3",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT9",
                    Email = "student1@gmail.com",
                    NormalizedEmail = "STUDENT1@GMAIL.COM",
                    FullName = "student1",
                    UserName = "student1",
                    NormalizedUserName = "STUDENT1",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT10",
                    Email = "student2@gmail.com",
                    NormalizedEmail = "STUDENT2@GMAIL.COM",
                    FullName = "student2",
                    UserName = "student2",
                    NormalizedUserName = "STUDENT2",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT11",
                    Email = "student3@gmail.com",
                    NormalizedEmail = "STUDENT3@GMAIL.COM",
                    FullName = "student3",
                    UserName = "student3",
                    NormalizedUserName = "STUDENT3",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                }*/
                );
        }
    }
}
