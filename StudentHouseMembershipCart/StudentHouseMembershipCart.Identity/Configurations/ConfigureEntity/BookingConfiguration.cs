using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    Id = Guid.Parse("8C5BCCD4-56B6-4B76-8D5B-888872A8B71F"),
                    Contract = "Hợp đồng Rửa xe",
                    TotalPay = 1234.5,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("9388A4E7-AE81-40D4-834C-463CFCCB6F53"),
                },

                new Booking
                {
                    Id = Guid.Parse("256FA734-309C-44A9-AF6A-8A97866FBFF5"),
                    Contract = "Hợp đồng giặt đồ",
                    TotalPay = 1222.5,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("EE8BD315-0201-46DB-BCAB-B1292F97E91D"),
                },

                new Booking
                {
                    Id = Guid.Parse("85D3DA16-8F33-4C96-9792-1E6E17D3ECC8"),
                    Contract = "Hợp đồng dọn vệ sinh nhà cửa",
                    TotalPay = 2233.3,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("81F9A432-7E27-4B3E-A354-DFAF3F1C164C"),
                },

                new Booking
                {
                    Id = Guid.Parse("A39735C8-440D-440F-9A5F-932164975749"),
                    Contract = "Hợp đồng dịch vụ hỗ trợ tài chính",
                    TotalPay = 2233.3,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("9388A4E7-AE81-40D4-834C-463CFCCB6F53"),
                },
                new Booking
                {
                    Id = Guid.Parse("3533264C-3BDD-4744-9023-481F5EC99CD6"),
                    Contract = "Hợp đồng vận chuyển đồ",
                    TotalPay = 2233.3,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("EE8BD315-0201-46DB-BCAB-B1292F97E91D"),
                },
                new Booking
                {
                    Id = Guid.Parse("CE7FDF8D-C130-4E5C-B2F4-6199153A5926"),
                    Contract = "Hợp đồng nấu ăn cho em",
                    TotalPay = 2233.3,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("81F9A432-7E27-4B3E-A354-DFAF3F1C164C"),
                }
            );
        }
    }
}
