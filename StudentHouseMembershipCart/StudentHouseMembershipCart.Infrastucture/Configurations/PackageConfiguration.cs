using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasData(
                new Package
                {
                    PackageName = "Maintenance & Repairs Package",
                    weekNumberBooking = 6,
                    numberOfPerWeekDoPackage = 2,
                    Image = null,
                    AdminId = Guid.Parse("D6C62CBF-F481-481B-9115-FF3B14B857C2"),
                },
                new Package
                {
                    PackageName = "Utility package",
                    weekNumberBooking = 8,
                    numberOfPerWeekDoPackage = 2,
                    Image = null,
                    AdminId = Guid.Parse("D6C62CBF-F481-481B-9115-FF3B14B857C2"),
                },
                new Package
                {
                    PackageName = "Shipping package",
                    weekNumberBooking = 1,
                    numberOfPerWeekDoPackage = 1,
                    Image = null,
                    AdminId = Guid.Parse("D6C62CBF-F481-481B-9115-FF3B14B857C2"),
                }
            ); 
        } 
    }
}


