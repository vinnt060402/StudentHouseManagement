using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(
                 new Admin
                 {
                     Id = Guid.Parse("90CA347F-831F-4B75-98BB-AE825B3EFC15"),
                     AdminName = "Admin",
                     Password = "123456",
                     RoleId = 1,
                 }
            ) ; 
        }
    }
}


