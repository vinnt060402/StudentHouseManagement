using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Student : BaseAuditableEntity  
    {
        public string StudentName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
