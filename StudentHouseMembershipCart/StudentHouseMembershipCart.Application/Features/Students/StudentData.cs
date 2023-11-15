using StudentHouseMembershipCart.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.Students
{
    public class StudentDataNew
    {
        public StudentData StudentData { get; set; } = null!;
        public ApplicationStudent ApplicationUserData { get; set; } = null!;
        public List<ApartmentData>? ApartmentData { get; set; }
    }
    public class ApplicationStudent
    {
        public string Id { get; set; }
        public string? FullName { get; set; }
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public string? EmailConfirmed { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
    }
    public class StudentData
    {
        public Guid Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string? ApplicationUserId { get; set; }

        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
    }
    public class ApartmentData
    {
        public Guid Id { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Region")]
        public Guid RegionId { get; set; }

    }
}