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
                    Email = "vi@gmail.com",
                    NormalizedEmail = "VI@GMAIL.COM",
                    FullName = "Nguyen Vi",
                    UserName = "vi@gmail.com",
                    NormalizedUserName = "VI@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "ACCOUNT2",
                    Email = "nhan@gmail.com",
                    NormalizedEmail = "NHAN@GMAIL.COM",
                    FullName = "Nguyen Nhan",
                    UserName = "nhan@gmail.com",
                    NormalizedUserName = "NHAN@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
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
                }
                );
        }
    }
}
