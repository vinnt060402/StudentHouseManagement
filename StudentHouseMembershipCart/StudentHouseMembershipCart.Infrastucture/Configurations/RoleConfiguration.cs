using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = Guid.Parse("B778F89A-A306-42A4-84FD-1BE8F795DC1A"),
                    RoleId = 1,
                    RoleName = "Staff",
                    Description = "Description"
                },
                new Role
                {
                    Id = Guid.Parse("87791989-38CC-4A41-9526-2052BC34258E"),
                    RoleId = 2,
                    RoleName = "Student",
                    Description = "Description",
                },
                new Role
                {
                    Id = Guid.Parse("B5196CAE-9E27-434E-BFD3-2C9DB9205EEF"),
                    RoleId = 3,
                    RoleName = "Admin",
                    Description = "Description",
                }
                );
        }
    }
}
