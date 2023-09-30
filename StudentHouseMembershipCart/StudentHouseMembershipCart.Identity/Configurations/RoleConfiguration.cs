using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentHouseMembershipCart.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ROLE1",
                    Name = "Student",
                    NormalizedName = "Student",
                },
                new IdentityRole
                {
                    Id = "ROLE2",
                    Name = "Staff",
                    NormalizedName = "Staff",
                },
                new IdentityRole
                {
                    Id = "ROLE3",
                    Name = "Admin",
                    NormalizedName = "Admin",
                }
                );
        }
    }
}
