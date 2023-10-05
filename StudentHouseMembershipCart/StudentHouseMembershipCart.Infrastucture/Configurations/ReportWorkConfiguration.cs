using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    internal class ReportWorkConfiguration : IEntityTypeConfiguration<ReportWork>
    {
        public void Configure(EntityTypeBuilder<ReportWork> builder)
        {
            builder.HasData(
                new ReportWork
                {
                    DescriptionProcess = "Process is successed",
                    Image = "abc",
                    StaffId = Guid.Parse("E44A5BE1-EFF1-42CC-B9AC-C78ADAC55AEB"),
                },
                new ReportWork
                {
                    DescriptionProcess = "Process is failed",
                    Image = "abc",
                    StaffId = Guid.Parse("264806D2-D9CD-4430-8B85-BE0E90C29B25"),
                },
                new ReportWork
                {
                    DescriptionProcess = "Process is successed",
                    Image = "abc",
                    StaffId = Guid.Parse("1457DEC7-79C7-4D33-8CF9-376C6B70F6B1"),
                }
            );
        }
    }
}
