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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = "C001",
                    CategoryName = "Maintenance",
                },
                new Category
                {
                    CategoryId = "C002",
                    CategoryName = "Utilities",
                },
                new Category
                {
                    CategoryId = "C003",
                    CategoryName = "Pet Services",
                }
                );
        }
    }
}
