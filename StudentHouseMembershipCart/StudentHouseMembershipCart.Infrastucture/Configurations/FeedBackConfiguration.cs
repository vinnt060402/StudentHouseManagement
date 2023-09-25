using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Infrastucture.Configurations
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.HasData(
                new FeedBack
                {
                    Id = Guid.Parse("0073AE3E-6374-4C66-9A7D-F2E1D411D3B2"),
                    FeedBackName = "hihi",
                    FeedBackDescription = "",
                    FeedBackImage = "", 
                    FeedBackRating = ""
                    
                },
                new FeedBack
                {
                    Id = Guid.Parse("5E6E3AC9-D41C-46F1-A4A4-E91ECEC521FD"),
                    FeedBackName = "hahah",
                    FeedBackDescription = "",
                    FeedBackImage = "",
                    FeedBackRating = ""
                }
            );
        }
    }
}
