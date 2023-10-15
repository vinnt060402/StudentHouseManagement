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
                    DescriptionProcess = "Giao hàng đến 123/8 Long Thạnh Mỹ, Quận 9. Thành Công!!!",
                    Image = "abc",
                    AttendReportId = Guid.Parse("742A0CF9-14AE-47AC-963B-03A096EF80A2"),
                    StaffId = Guid.Parse("D36A73ED-78AE-46AF-BEFD-7B90CBCFC479"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("120E1AAA-EED0-445F-943A-20BC12F4B883"),
                    DescriptionProcess = "Lau tủ, Lau bếp, Rửa chén. Hoàn Thành",
                    Image = "abc",
                    AttendReportId = Guid.Parse("D9A5AF9C-CE76-43AB-9FC4-46442E495F59"),
                    StaffId = Guid.Parse("C085539D-76BD-4FE8-9444-12C21DE6610B"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("BD3D72CC-551A-4ABF-B358-D6D980BDDB67"),
                    DescriptionProcess = "Sửa ống nước, thay van. Thành công",
                    Image = "abc",
                    AttendReportId = Guid.Parse("275B2720-420D-4B33-835A-4651D92F1390"),
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                }/*
                new ReportWork
                {
                    Id = Guid.Parse("6F187FCD-C544-46C4-BDB1-38CD254FFCAE"),
                    DescriptionProcess = "Giặt đồ sạch sẽ",
                    Image = "abc",
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("E104A356-2BAF-4BF9-A3D8-B1463352C3E7"),
                    DescriptionProcess = "Nấu 3 món: canh, cá, rau luộc",
                    Image = "abc",
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("6323937A-3B10-4277-8D7B-E61368BD8CF9"),
                    DescriptionProcess = "Cho vay thành công, hẹn ngày trả tiền!",
                    Image = "abc",
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                },
                new ReportWork
                {
                    Id = Guid.Parse("B1BCF1D6-5B2E-43DD-8645-6738D6787924"),
                    DescriptionProcess = "Thay nhớt, pha bột rửa xe, bơm bánh, kiểm tra hệ thống xe, lau khô",
                    Image = "abc",
                    StaffId = Guid.Parse("A8DED7DD-683F-4231-8C47-560375560EEA"),
                }*/
            ) ;
        }
    }
}
