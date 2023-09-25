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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = Guid.Parse("F9589C1A-3CBC-4215-BB84-B8FA7D719420"),
                    StudentName = "Staff",
                    Password = "MANAGER",
                    Email = "Staff@gmail.com",
                    Birthday = DateTime.Parse("2023-05-09"),
                    Phone = "03030303",
                    Address = "da nang",
                    RoleId = Guid.Parse("87791989-38CC-4A41-9526-2052BC34258E"),
                    FeedbackId = Guid.Parse("0073AE3E-6374-4C66-9A7D-F2E1D411D3B2")
                },
                new Student
                {
                    Id = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                    StudentName = "Manager",
                    Password = "MANAGER",
                    Email = "Manager@gmail.com",
                    Birthday = DateTime.Now,
                    Phone = "03030303",
                    Address = "hcm",
                    RoleId = Guid.Parse("87791989-38CC-4A41-9526-2052BC34258E"),
                    FeedbackId = Guid.Parse("0073AE3E-6374-4C66-9A7D-F2E1D411D3B2")
                },
                new Student
                {
                    Id = Guid.Parse("{46F50A4A-327E-47F1-A43C-D31B6B39B939}"),
                    StudentName = "MapDit",
                    Password = "123546",
                    Email = "MapDit@gmail.com",
                    Birthday = DateTime.Now,
                    Phone = "03030303",
                    Address = "ha-noi",
                    RoleId = Guid.Parse("87791989-38CC-4A41-9526-2052BC34258E"),
                    FeedbackId = Guid.Parse("5E6E3AC9-D41C-46F1-A4A4-E91ECEC521FD")
                }
            );
        }
    }
}
