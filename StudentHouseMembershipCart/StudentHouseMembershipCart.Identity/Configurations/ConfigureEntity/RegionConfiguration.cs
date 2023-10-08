using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData(
                new Region
                {
                    Id = Guid.Parse("BD3DB160-9064-458B-9974-AEAA876D1EF4"),
                    RegionName = "Quan 8",
                },
                new Region
                {
                    Id = Guid.Parse("3A60F12A-8C9A-4985-A215-0C55438F363B"),
                    RegionName = "Dong Nai",
                },
                new Region
                {
                    Id = Guid.Parse("34303CCB-2C3E-4CEE-84F3-B3352D67D790"),
                    RegionName = "Quan Binh Thanh",
                }
            );
        }
    }
}
