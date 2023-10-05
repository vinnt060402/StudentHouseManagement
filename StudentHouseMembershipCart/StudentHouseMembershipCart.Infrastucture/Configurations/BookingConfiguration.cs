using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    Id = Guid.Parse("8C5BCCD4-56B6-4B76-8D5B-888872A8B71F"),
                    Contract = "10 weeks",
                    TotalPay = 1234.5,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("694F09D1-31F8-459E-A930-5F61D1FC27BB"),
                },

                new Booking
                {
                    Id = Guid.Parse("256FA734-309C-44A9-AF6A-8A97866FBFF5"),
                    Contract = "12 weeks",
                    TotalPay = 1222.5,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("85D3DA16-8F33-4C96-9792-1E6E17D3ECC8"),
                },

                new Booking
                {
                    Id = Guid.Parse("85D3DA16-8F33-4C96-9792-1E6E17D3ECC8"),
                    Contract = "14 weeks",
                    TotalPay = 2233.3,
                    StartDate = DateTime.Now,
                    ApartmentId = Guid.Parse("4BB4AEDF-5CDC-4C31-8DEA-B109D9FEF08F"),
                }
            );
        }
    }
}

