using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class BookingDetailStaffConfiguration : IEntityTypeConfiguration<BookingDetailStaff>
    {
        public void Configure(EntityTypeBuilder<BookingDetailStaff> builder)
        {
            builder.HasData(
                new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse("E05D66A3-74E9-4084-A3AC-064C58EE6545"),
                    StaffId = Guid.Parse("78DB9BDE-2456-4C5B-BC3A-F5F0931C8A28"),
                },
                new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse("AFCD5050-197F-4FD1-ADDD-B6BA803DC366"),
                    StaffId = Guid.Parse("CD255CDC-CD54-4893-AC24-1B2E20B4FE9D"),
                },
                new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse("3E1A6C7A-EB63-484E-98F1-04923BF03D99"),
                    StaffId = Guid.Parse("1AA6352F-415D-44BB-814E-8124AB4C1DB1"),
                }
            );
        }
    }
}
