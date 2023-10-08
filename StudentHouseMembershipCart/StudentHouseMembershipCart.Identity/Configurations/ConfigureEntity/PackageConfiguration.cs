using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasData(
                new Package
                {
                    Id = Guid.Parse("EE75EA18-F6A7-4025-84B7-588AB1C6BF2D"),
                    PackageName = "Maintenance & Repairs Package",
                    weekNumberBooking = 6,
                    numberOfPerWeekDoPackage = 2,
                    Image = null,
                    AdminId = Guid.Parse("90CA347F-831F-4B75-98BB-AE825B3EFC15"),
                },
                new Package
                {
                    Id = Guid.Parse("98A974DB-90FB-453F-83CC-B49776EACFB3"),
                    PackageName = "Utility package",
                    weekNumberBooking = 8,
                    numberOfPerWeekDoPackage = 2,
                    Image = null,
                    AdminId = Guid.Parse("90CA347F-831F-4B75-98BB-AE825B3EFC15"),
                },
                new Package
                {
                    Id = Guid.Parse("68E3BF2B-2BD7-4428-AC39-148F1A186CBA"),
                    PackageName = "Shipping package",
                    weekNumberBooking = 1,
                    numberOfPerWeekDoPackage = 1,
                    Image = null,
                    AdminId = Guid.Parse("90CA347F-831F-4B75-98BB-AE825B3EFC15"),
                }
            );
        }
    }
}
