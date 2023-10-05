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
    public class PackageServiceConfiguration : IEntityTypeConfiguration<PackageService>
    {
        public void Configure(EntityTypeBuilder<PackageService> builder)
        {
            builder.HasData(
                new PackageService
                {
                    PackageId = Guid.Parse("D74C4A32-6847-44F7-8E1C-4287F0EA1A47"),
                    ServiceId = Guid.Parse("CFF67E92-014E-409A-AE69-D6088CA4CA16"),
                },
                new PackageService
                {
                    PackageId = Guid.Parse("073FD720-954B-4F7C-BBBC-012FB22BDEF1"),
                    ServiceId = Guid.Parse("B0921381-51BF-4F8D-9ED9-A91CC28770C9"),
                },
                new PackageService
                {
                    PackageId = Guid.Parse("15919EEE-4733-45B6-A0C0-FE81738EE82E"),
                    ServiceId = Guid.Parse("045ADF6C-D305-408B-A146-94C2324915BF"),
                }
            );
        }
    }
}
