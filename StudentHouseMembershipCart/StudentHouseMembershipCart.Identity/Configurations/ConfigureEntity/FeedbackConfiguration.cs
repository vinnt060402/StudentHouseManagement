using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.HasData(
                new FeedBack
                {
                    Id = Guid.Parse("2372F547-375E-4F88-A726-37643180C585"),
                    FeedBackName = "Feedback dọn dẹp nhà cửa của căn hộ 0504 vinhomes",
                    FeedBackDescription = "dọn dẹp cực kì có tâm, lao nhà quá sạch, đi muốn té tét đầu",
                    FeedBackImage = "/url/asdas/sadas",
                    FeedBackRating = "5 sao",
                    StudentId = Guid.Parse("F9589C1A-3CBC-4215-BB84-B8FA7D719420"),
                    AttendReportId = Guid.Parse("D9A5AF9C-CE76-43AB-9FC4-46442E495F59")
                },
                new FeedBack
                {
                    Id = Guid.Parse("FC2E4D71-9E75-40D9-972C-A36ECAD80887"),
                    FeedBackName = "Feedback rửa xe máy winner X của a Vĩ",
                    FeedBackDescription = "Rửa xe sạch bon bon, soi thấy cục mụn, nhưng bơm bánh xe hơi căng",
                    FeedBackImage = "/url/asdas/sadas",
                    FeedBackRating = "4,5 sao",
                    StudentId = Guid.Parse("F9589C1A-3CBC-4215-BB84-B8FA7D719420"),
                    AttendReportId = Guid.Parse("275B2720-420D-4B33-835A-4651D92F1390")
                },
                new FeedBack
                {
                    Id = Guid.Parse("0730329F-EBCB-484D-8DD0-E32BB3DE78A4"),
                    FeedBackName = "Feedback nấu ăn cho em",
                    FeedBackDescription = "Cơm cô 3 và chị 7 nấu rất là ngon và trắng, nói chung tuyệt cú mèo",
                    FeedBackImage = "/url/asdas/sadas",
                    FeedBackRating = "5 sao",
                    StudentId = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                    AttendReportId = Guid.Parse("046B87C6-E4B5-4F08-9951-9EBF4BC20993")
                },
                new FeedBack
                {
                    Id = Guid.Parse("53838B2B-A19F-422A-8F62-6363476C21DA"),
                    FeedBackName = "Feedback chuyển nhà cho sinh viên nghèo vượt khó",
                    FeedBackDescription = "vận chuyển đúng thời gian và quy định của kí túc xá, Quá đã pepsi ơi!!!",
                    FeedBackImage = "/url/asdas/sadas",
                    FeedBackRating = "4 sao",
                    StudentId = Guid.Parse("46F50A4A-327E-47F1-A43C-D31B6B39B939"),
                    AttendReportId = Guid.Parse("742A0CF9-14AE-47AC-963B-03A096EF80A2")
                },
                new FeedBack
                {
                    Id = Guid.Parse("6863F4FB-EEF5-4F26-8FCF-8736AA8ADE95"),
                    FeedBackName = "Feedback hỗ trợ tài chánh cho sinh viên nghiện.",
                    FeedBackDescription = "Quả thật là vị cứu tinh đúng nghĩa, 10 điểm không có nhưng",
                    FeedBackImage = "/url/asdas/sadas",
                    FeedBackRating = "5 sao",
                    StudentId = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                    AttendReportId = Guid.Parse("CCBA7E84-40ED-4D32-B98F-E3E5181A924F")
                }
            ); 
        }

    }
}


