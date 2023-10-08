using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("8ABB3DDA-208B-4397-93C0-3A5269A90E3D"),
                    CategoryName = "Maintenance",
                },
                new Category
                {
                    Id = Guid.Parse("9DF988F5-0382-4939-8EEE-09D47B182BBB"),
                    CategoryName = "Utilities",
                },
                new Category
                {
                    Id = Guid.Parse("1819643B-2533-461D-8ACC-AA0628E0AF10"),
                    CategoryName = "Pet Services",
                }
                );
        }
    }
}
