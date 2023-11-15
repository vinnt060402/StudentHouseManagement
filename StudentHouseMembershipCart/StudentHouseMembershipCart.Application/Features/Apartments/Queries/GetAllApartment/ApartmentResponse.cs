using StudentHouseMembershipCart.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment
{
    public class ApartmentResponse
    {
        public Guid Id { get; set; }
        public string Address { get; set; }

        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Region")]
        public Guid RegionId { get; set; }

        public Student? InforStudentData { get; set; }
        public Region? InforRegionData { get; set; }
    }
}