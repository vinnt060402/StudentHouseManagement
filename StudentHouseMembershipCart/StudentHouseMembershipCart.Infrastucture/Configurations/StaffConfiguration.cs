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
    internal class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    staffName = "Staff 1",
                    Phone = 0256231142,
                    Email = "staff1@gamil.com",
                    Address = "Dong Nai",
                    Birthday = DateTime.Parse("1999-05-09"),
                    Password = "123456",
                    RoleId = 2
                },
                new Staff
                {
                    staffName = "Staff 2",
                    Phone = 0121365124,
                    Email = "staff2@gamil.com",
                    Address = "An Giang",
                    Birthday = DateTime.Parse("1990-07-02"),
                    Password = "123456",
                    RoleId = 2
                },
                new Staff
                {
                    staffName = "Staff 3",
                    Phone = 0125945632,
                    Email = "staff3@gamil.com",
                    Address = "Long An",
                    Birthday = DateTime.Parse("2000-11-15"),
                    Password = "123456",
                    RoleId = 2
                }
            );
        }
    }
}
