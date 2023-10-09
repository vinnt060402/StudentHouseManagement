using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class PackageServiceConfiguration : IEntityTypeConfiguration<PackageService>
    {
        public void Configure(EntityTypeBuilder<PackageService> builder)
        {
            builder.HasData(
                    new PackageService
                    {
                        Id = Guid.Parse("D036463D-887E-4A3C-AAAB-4FCE577E43DB"),
                        PackageId = Guid.Parse("C0E52326-C1C2-4C58-A5D9-D6A768E0C7A9"),
                        ServiceId = Guid.Parse("E430FCFB-DE6A-4C64-A6CA-B607E1357843")
                    },
                    new PackageService
                    {
                        Id = Guid.Parse("95786A5F-3068-4628-AD2F-2BCC70DE8661"),
                        PackageId = Guid.Parse("D0E4FC80-5E14-4F54-B3D3-90FFF85DF063"),
                        ServiceId = Guid.Parse("30743744-754B-4A87-B828-6186CCC7ECE6")
                    },
                    new PackageService
                    {
                        Id = Guid.Parse("FC2C6CBB-1D78-48E4-BE82-FC2870275030"),
                        PackageId = Guid.Parse("4DA4E6AD-3328-4F03-964E-C31E1A8421F3"),
                        ServiceId = Guid.Parse("FA87282B-0C28-4DC7-831D-E1D8F8026270")
                    },
                    new PackageService
                    {
                        Id = Guid.Parse("B7A93559-D76D-40F3-973E-B550DBC8AD74"),
                        PackageId = Guid.Parse("649CE925-0CD1-4CB2-9FB2-4C6AE8FF521E"),
                        ServiceId = Guid.Parse("29140864-8E89-41B6-8FD7-A440800E6E00")
                    },
                    new PackageService
                    {
                        Id = Guid.Parse("D42D5044-1E4E-4C77-8E6E-0FAE60AD1D17"),
                        PackageId = Guid.Parse("EE75EA18-F6A7-4025-84B7-588AB1C6BF2D"),
                        ServiceId = Guid.Parse("4FCC0684-AD33-433F-9338-D9E949B6F0D8")
                    }
            );
        }

    }
}


