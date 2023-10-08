using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
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
                    CategoryId = Guid.Parse("8ABB3DDA-208B-4397-93C0-3A5269A90E3D"),
                },
                new Service
                {
                    ServiceName = "Service 2",
                    ServiceDescription = "Service is OK",
                    Quantity = "4",
                    Image = "abc",
                    CategoryId = Guid.Parse("9DF988F5-0382-4939-8EEE-09D47B182BBB"),
                },
                new Service
                {
                    ServiceName = "Service 3",
                    ServiceDescription = "Service is OK",
                    Quantity = "2",
                    Image = "abc",
                    CategoryId = Guid.Parse("1819643B-2533-461D-8ACC-AA0628E0AF10"),
                }
            );
        }
    }
}
