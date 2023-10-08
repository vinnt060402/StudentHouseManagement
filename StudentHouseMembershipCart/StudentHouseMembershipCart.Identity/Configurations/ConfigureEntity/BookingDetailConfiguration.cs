using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.HasData(
                new BookingDetail
                {
                    Id = Guid.Parse("BE08997C-61A5-4859-98A2-459C93DCA574"),
                    BookingDetailName = "Booking 1",
                    Price = 2222.2,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 1,
                    ContractName = "Contract 1",
                    ContractDescription = "Description 1",
                    BookingId = Guid.Parse("8C5BCCD4-56B6-4B76-8D5B-888872A8B71F"),
                    PackageId = Guid.Parse("EE75EA18-F6A7-4025-84B7-588AB1C6BF2D"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("035C6D92-8FB5-4635-8ACF-1821E7296DAE"),
                    BookingDetailName = "Booking 2",
                    Price = 3333.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 2,
                    ContractName = "Contract 2",
                    ContractDescription = "Description 2",
                    BookingId = Guid.Parse("256FA734-309C-44A9-AF6A-8A97866FBFF5"),
                    PackageId = Guid.Parse("98A974DB-90FB-453F-83CC-B49776EACFB3"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("2408CC34-D225-448E-979E-014D1EC860A3"),
                    BookingDetailName = "Booking 3",
                    Price = 3232.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 3,
                    ContractName = "Contract 3",
                    ContractDescription = "Description 3",
                    BookingId = Guid.Parse("85D3DA16-8F33-4C96-9792-1E6E17D3ECC8"),
                    PackageId = Guid.Parse("68E3BF2B-2BD7-4428-AC39-148F1A186CBA"),
                }
            );
        }
    }
}
