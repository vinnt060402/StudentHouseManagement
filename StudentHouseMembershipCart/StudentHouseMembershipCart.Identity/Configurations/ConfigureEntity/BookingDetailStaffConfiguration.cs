using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class BookingDetailStaffConfiguration : IEntityTypeConfiguration<BookingDetailStaff>
    {
        public void Configure(EntityTypeBuilder<BookingDetailStaff> builder)
        {
            builder.HasData(
                new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse("BE08997C-61A5-4859-98A2-459C93DCA574"),
                    StaffId = Guid.Parse("D36A73ED-78AE-46AF-BEFD-7B90CBCFC479"),
                },
                new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse("035C6D92-8FB5-4635-8ACF-1821E7296DAE"),
                    StaffId = Guid.Parse("C085539D-76BD-4FE8-9444-12C21DE6610B"),
                },
                new BookingDetailStaff
                {
                    BookingDetailId = Guid.Parse("2408CC34-D225-448E-979E-014D1EC860A3"),
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                }
            );
        }
    }
}
