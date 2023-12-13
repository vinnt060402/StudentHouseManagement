using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(
                 new Admin
                 {
                     Id = Guid.Parse("90CA347F-831F-4B75-98BB-AE825B3EFC15"),
                     AdminName = "Admin",
                     ApplicationUserId = "ACCOUNT1",
                 }
            ) ; 
        }
    }
}


