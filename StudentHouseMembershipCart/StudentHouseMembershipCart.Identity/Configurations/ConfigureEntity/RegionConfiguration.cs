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
                    RegionName = "Quận 8",
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
                },
                new Region
                {
                    Id = Guid.Parse("6DB6D0CF-A3A4-4C12-8F0D-41C4FF579AE6"),
                    RegionName = "Quận 11",
                },
                new Region
                {
                    Id = Guid.Parse("62F16917-B22A-4B17-B93D-5A9F35C5B8F4"),
                    RegionName = "Quận 12",
                },
                new Region
                {
                    Id = Guid.Parse("83326CB5-B249-4BA3-AA98-87752A99DF53"),
                    RegionName = "Hóc Môn",
                },
                new Region
                {
                    Id = Guid.Parse("006AEB5A-7574-40CA-A73E-DA840ECEB810"),
                    RegionName = "Quận 1",
                },
                new Region
                {
                    Id = Guid.Parse("2BB177E5-2180-4CE0-BBF2-AF5BC9EEEFCC"),
                    RegionName = "Quận 2",
                },
                new Region
                {
                    Id = Guid.Parse("3B0AB201-058E-4314-8B5C-DF3C7D831DDC"),
                    RegionName = "Quận 3",
                },
                new Region
                {
                    Id = Guid.Parse("9FFBFC1A-45D7-42D1-B216-00F328FE1638"),
                    RegionName = "Quận 9",
                },
                new Region
                {
                    Id = Guid.Parse("2429516B-5620-4838-912F-F4826F5D28BD"),
                    RegionName = "Quận 7",
                },
                new Region
                {
                    Id = Guid.Parse("8725E1C4-E76B-4563-916B-A668516237E2"),
                    RegionName = "Quận 4",
                },
                new Region
                {
                    Id = Guid.Parse("0DBD39F5-CD9B-4E7F-8D53-851014A4EFA0"),
                    RegionName = "Quận 5",
                },
                new Region
                {
                    Id = Guid.Parse("FC4CFB1B-063E-4F31-B25F-B0853A401350"),
                    RegionName = "Quận 6",
                }
            );
        }
    }
}
