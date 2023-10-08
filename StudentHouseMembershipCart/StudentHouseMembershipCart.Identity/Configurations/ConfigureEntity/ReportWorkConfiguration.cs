using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class ReportWorkConfiguration : IEntityTypeConfiguration<ReportWork>
    {
        public void Configure(EntityTypeBuilder<ReportWork> builder)
        {
            builder.HasData(
                new ReportWork
                {
                    Id = Guid.Parse("991B3FF2-962F-439A-AEC6-051D522A8904"),
                    DescriptionProcess = "Process is successed",
                    Image = "abc",
                    StaffId = Guid.Parse("D36A73ED-78AE-46AF-BEFD-7B90CBCFC479"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("120E1AAA-EED0-445F-943A-20BC12F4B883"),
                    DescriptionProcess = "Process is failed",
                    Image = "abc",
                    StaffId = Guid.Parse("C085539D-76BD-4FE8-9444-12C21DE6610B"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("BD3D72CC-551A-4ABF-B358-D6D980BDDB67"),
                    DescriptionProcess = "Process is successed",
                    Image = "abc",
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                }
            ) ;
        }
    }
}
