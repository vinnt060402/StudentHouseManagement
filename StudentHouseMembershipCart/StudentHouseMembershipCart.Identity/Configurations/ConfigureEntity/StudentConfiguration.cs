/*using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = Guid.Parse("F9589C1A-3CBC-4215-BB84-B8FA7D719420"),
                    Birthday = DateTime.Parse("2023-05-09"),
                    ApplicationUserId = "ACCOUNT9",
                    Phone = "0961868641",
                    Address = "Đà Nẵng",
                },
                new Student
                {
                    Id = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                    Birthday = DateTime.Now,
                    ApplicationUserId = "ACCOUNT10",
                    Phone = "0312357823",
                    Address = "Hồ Chí Minh",
                },
                new Student
                {
                    Id = Guid.Parse("46F50A4A-327E-47F1-A43C-D31B6B39B939"),
                    ApplicationUserId = "ACCOUNT11",
                    Birthday = DateTime.Now,
                    Phone = "0987451632",
                    Address = "Hà Nội",
                }
            );
        }
    }
}
*/