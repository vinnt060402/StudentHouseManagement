/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = Guid.Parse("D36A73ED-78AE-46AF-BEFD-7B90CBCFC479"),
                    staffName = "Staff 1",
                    ApplicationUserId = "ACCOUNT5",
                    Address = "Dong Nai",
                    Birthday = DateTime.Parse("1999-05-09"),
                },
                new Staff
                {
                    Id = Guid.Parse("C085539D-76BD-4FE8-9444-12C21DE6610B"),
                    staffName = "Staff 2",
                    ApplicationUserId = "ACCOUNT6",
                    Address = "An Giang",
                    Birthday = DateTime.Parse("1990-07-02")
                },
                new Staff
                {
                    Id = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                    staffName = "Staff 3",
                    ApplicationUserId = "ACCOUNT7",
                    Address = "Long An",
                    Birthday = DateTime.Parse("2000-11-15"),
                }
            );
        }
    }
}
*/