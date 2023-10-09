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
                    BookingDetailName = "Rửa xe",
                    Price = 2222.2,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 1,
                    ContractName = "Hợp đồng Rửa xe",
                    ContractDescription = "rửa xe, làm sạch bình xăng, đánh bóng",
                    BookingId = Guid.Parse("8C5BCCD4-56B6-4B76-8D5B-888872A8B71F"),
                    PackageId = Guid.Parse("68E3BF2B-2BD7-4428-AC39-148F1A186CBA"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("035C6D92-8FB5-4635-8ACF-1821E7296DAE"),
                    BookingDetailName = "Giặt đồ",
                    Price = 3333.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 2,
                    ContractName = "Hợp đồng giặt đồ",
                    ContractDescription = "giá cả, thời gian và địa điểm, bảo hành",
                    BookingId = Guid.Parse("256FA734-309C-44A9-AF6A-8A97866FBFF5"),
                    PackageId = Guid.Parse("C0E52326-C1C2-4C58-A5D9-D6A768E0C7A9"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("2408CC34-D225-448E-979E-014D1EC860A3"),
                    BookingDetailName = "Dọn vệ sinh nhà cửa",
                    Price = 3232.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 3,
                    ContractName = "Hợp đồng dọn vệ sinh nhà cửa",
                    ContractDescription = "giá cả, lịch trình làm việc, các điều kiện thanh toán",
                    BookingId = Guid.Parse("85D3DA16-8F33-4C96-9792-1E6E17D3ECC8"),
                    PackageId = Guid.Parse("D0E4FC80-5E14-4F54-B3D3-90FFF85DF063"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("CD4DE656-DBFE-4797-8F8D-130DED6A6774"),
                    BookingDetailName = "Hỗ trợ tài chính",
                    Price = 3232.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 3,
                    ContractName = "Hợp đồng dịch vụ hỗ trợ tài chính",
                    ContractDescription = "giá cả, điều kiện thanh toán, và nghĩa vụ của cả hai bên",
                    BookingId = Guid.Parse("A39735C8-440D-440F-9A5F-932164975749"),
                    PackageId = Guid.Parse("649CE925-0CD1-4CB2-9FB2-4C6AE8FF521E"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("A2A79FB8-A2F5-4F98-9B36-22EEB1A1215C"),
                    BookingDetailName = "Nấu ăn cho iemmm",
                    Price = 3232.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 3,
                    ContractName = "Hợp đồng dịch vụ nấu ăn mỗi ngày cho bé",
                    ContractDescription = "giá cả, điều kiện thanh toán, và nghĩa vụ của cả hai bên",
                    BookingId = Guid.Parse("CE7FDF8D-C130-4E5C-B2F4-6199153A5926"),
                    PackageId = Guid.Parse("68E3BF2B-2BD7-4428-AC39-148F1A186CBA"),
                },
                new BookingDetail
                {
                    Id = Guid.Parse("1F4D83E2-3713-4FFF-9FC5-5373C20CC2CC"),
                    BookingDetailName = "Dịch vụ Chuyển Nhà",
                    Price = 3232.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 3,
                    ContractName = "Hợp đồng dịch vụ chuyển nhà siêu tốc",
                    ContractDescription = "giá cả, điều kiện thanh toán, và quy trình vận chuyển và đúng kế hoạch",
                    BookingId = Guid.Parse("3533264C-3BDD-4744-9023-481F5EC99CD6"),
                    PackageId = Guid.Parse("B17C9D4C-B164-4097-8D5F-03D2246DA758"),
                }
            );
        }
    }
}
