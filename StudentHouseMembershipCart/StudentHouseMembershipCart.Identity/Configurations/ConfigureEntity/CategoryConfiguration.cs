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
                    CategoryName = "Rửa xe",
                },
                new Category
                {
                    Id = Guid.Parse("9DF988F5-0382-4939-8EEE-09D47B182BBB"),
                    CategoryName = "Nấu ăn",
                },
                new Category
                {
                    Id = Guid.Parse("375A894D-E8E5-4A84-A0B8-09F907992B46"),
                    CategoryName = "Vận Chuyển",
                },
                new Category
                {
                    Id = Guid.Parse("8940E7F6-FD91-4402-A515-B9D55448C522"),
                    CategoryName = "Mua sắm",
                },
                new Category
                {
                    Id = Guid.Parse("21291667-7546-4825-9BAD-840D648900A3"),
                    CategoryName = "Dọn vệ sinh nhà cửa",
                },
                new Category
                {
                    Id = Guid.Parse("BA0F3F23-9425-44AD-9D73-A7608381FD5F"),
                    CategoryName = "Bảo trì và sửa chữa",
                },
                new Category
                {
                    Id = Guid.Parse("A3CCB973-D6C4-4EF4-AE4B-36A97429A0B0"),
                    CategoryName = "Vui chơi và giải trí",
                }
                );
        }
    }
}
