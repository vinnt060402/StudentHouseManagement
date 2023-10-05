using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.HasData(
                new BookingDetail
                {
                    BookingDetailName = "Booking 1",
                    Price = 2222.2,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 1,
                    ContractName = "Contract 1",
                    ContractDescription = "Description 1",
                    BookingId = Guid.Parse("89311854-1527-420B-9D64-AAA01D6D4AC0"),
                    PackageId = Guid.Parse("1D42CB7A-24DF-466E-943D-A0FE6AEB3FA4"),
                },
                new BookingDetail
                {
                    BookingDetailName = "Booking 2",
                    Price = 3333.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 2,
                    ContractName = "Contract 2",
                    ContractDescription = "Description 2",
                    BookingId = Guid.Parse("46CA2B9C-057E-4C31-BB98-8E598DDCD797"),
                    PackageId = Guid.Parse("078DBA69-6807-41D2-8625-C8E82060EB09"),
                },
                new BookingDetail
                {
                    BookingDetailName = "Booking 3",
                    Price = 3232.3,
                    IsRe_Newed = true,
                    RenewStartDate = null,
                    remainingTaskDuration = 3,
                    ContractName = "Contract 3",
                    ContractDescription = "Description 3",
                    BookingId = Guid.Parse("800DF8E9-7C22-42EA-9F5F-B60C0C1B12E2"),
                    PackageId = Guid.Parse("E973F080-07EF-4FBB-8CD2-CBB7A8A72A4D"),
                }
            );
        }
    }
}
