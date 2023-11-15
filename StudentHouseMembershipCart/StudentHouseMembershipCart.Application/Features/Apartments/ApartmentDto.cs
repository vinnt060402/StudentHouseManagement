using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.Apartments
{
    public class ApartmentDto
    {
        public Guid Id { get; set; }
        public string Address { get; set; }

        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Region")]
        public Guid RegionId { get; set; }

    }
}