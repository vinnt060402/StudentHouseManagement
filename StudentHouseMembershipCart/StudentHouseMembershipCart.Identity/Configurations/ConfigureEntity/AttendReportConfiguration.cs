using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class AttendReportConfiguration : IEntityTypeConfiguration<AttendReport>
    {
        public void Configure(EntityTypeBuilder<AttendReport> builder)
        {
            builder.HasData(
                new AttendReport
                {
                    Id = Guid.Parse("D9A5AF9C-CE76-43AB-9FC4-46442E495F59"),
                    DateDoPackage = DateTime.Now,
                    BookingDetailId = Guid.Parse("2408CC34-D225-448E-979E-014D1EC860A3"),
                    ReportWorkId = Guid.Parse("120E1AAA-EED0-445F-943A-20BC12F4B883"),
                },
                new AttendReport
                {
                    Id = Guid.Parse("275B2720-420D-4B33-835A-4651D92F1390"),
                    DateDoPackage = DateTime.Now,
                    BookingDetailId = Guid.Parse("BE08997C-61A5-4859-98A2-459C93DCA574"),
                    ReportWorkId = Guid.Parse("B1BCF1D6-5B2E-43DD-8645-6738D6787924"),
                },
                new AttendReport
                {
                    Id = Guid.Parse("046B87C6-E4B5-4F08-9951-9EBF4BC20993"),
                    DateDoPackage = DateTime.Now,
                    BookingDetailId = Guid.Parse("A2A79FB8-A2F5-4F98-9B36-22EEB1A1215C"),
                    ReportWorkId = Guid.Parse("E104A356-2BAF-4BF9-A3D8-B1463352C3E7"),
                },
                new AttendReport
                {
                    Id = Guid.Parse("742A0CF9-14AE-47AC-963B-03A096EF80A2"),
                    DateDoPackage = DateTime.Now,
                    BookingDetailId = Guid.Parse("1F4D83E2-3713-4FFF-9FC5-5373C20CC2CC"),
                    ReportWorkId = Guid.Parse("991B3FF2-962F-439A-AEC6-051D522A8904"),
                },
                new AttendReport
                {
                    Id = Guid.Parse("CCBA7E84-40ED-4D32-B98F-E3E5181A924F"),
                    DateDoPackage = DateTime.Now,
                    BookingDetailId = Guid.Parse("CD4DE656-DBFE-4797-8F8D-130DED6A6774"),
                    ReportWorkId = Guid.Parse("6323937A-3B10-4277-8D7B-E61368BD8CF9"),
                }
            );
        }

    }
}


