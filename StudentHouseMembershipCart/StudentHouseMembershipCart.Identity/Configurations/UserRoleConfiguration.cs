using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentHouseMembershipCart.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ROLE1",
                    UserId = "ACCOUNT1"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "ROLE2",
                    UserId = "ACCOUNT2"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "ROLE3",
                    UserId = "ACCOUNT3"
                }
                );
        }
    }
}
