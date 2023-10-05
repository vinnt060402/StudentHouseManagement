using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasData(
                new Apartment
                {
                    Address = "286,phuong 24, quan Hai Ba Trung, Ha Noi",
                    StudentId = Guid.Parse("4E18E160-C678-41C0-938C-9E4D9D41A9AA"),
                    RegionId = Guid.Parse("322D2CD9-DF48-477A-A845-7A005A9B479F"),
                },
                new Apartment
                {
                    Address = "176, phuong 26, quan Binh Thanh, TP.HCM",
                    StudentId = Guid.Parse("334830FB-917E-4766-85BF-394329D42670"),
                    RegionId = Guid.Parse("3A60F12A-8C9A-4985-A215-0C55438F363B"),
                },
                new Apartment
                {
                    Address = "145, phuong 5, quan Hoan Kiem, Ha Noi",
                    StudentId = Guid.Parse("D83E37AB-7930-4479-9DB2-8106BB8B2BF5"),
                    RegionId = Guid.Parse("BD3DB160-9064-458B-9974-AEAA876D1EF4"),
                }
            );
        }
    }
}
