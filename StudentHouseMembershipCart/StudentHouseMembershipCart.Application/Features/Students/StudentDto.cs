using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.Students
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
    }
}