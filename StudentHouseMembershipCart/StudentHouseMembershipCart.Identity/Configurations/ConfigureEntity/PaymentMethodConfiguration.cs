using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasData(
                new PaymentMethod
                {
                    Id = Guid.Parse("E587848F-E7C9-4D8D-830C-EDDB838CDC25"),
                    PaymentMethodName = "Cash",
                    CreateBy = "Admin"
                },
                new PaymentMethod
                {
                    Id = Guid.Parse("E49E2E39-8ECA-42F5-8CFC-5DEADE7E331B"),
                    PaymentMethodName = "Credit Card",
                    CreateBy = "Admin"
                },
                new PaymentMethod
                {
                    Id = Guid.Parse("07760009-74E9-49DC-A286-3885FC816596"),
                    PaymentMethodName = "Bank Transfer",
                    CreateBy = "Admin"
                }
            );
        }

    }
}
