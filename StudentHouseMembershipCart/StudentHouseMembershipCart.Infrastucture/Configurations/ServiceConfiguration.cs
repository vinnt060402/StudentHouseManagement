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
    internal class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasData(
                new Service
                {
                    ServiceName = "Service 1",
                    ServiceDescription = "Service is OK",
                    Quantity = "5",
                    Image = "abc",
                    CategoryId = "Category 1",
                },
                new Service
                {
                    ServiceName = "Service 2",
                    ServiceDescription = "Service is OK",
                    Quantity = "4",
                    Image = "abc",
                    CategoryId = "Category 2",
                },
                new Service
                {
                    ServiceName = "Service 3",
                    ServiceDescription = "Service is OK",
                    Quantity = "2",
                    Image = "abc",
                    CategoryId = "Category 3",
                }
            );
        }
    }
}
