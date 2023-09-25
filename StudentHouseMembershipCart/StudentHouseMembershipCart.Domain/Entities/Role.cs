using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class Role : BaseAuditableEntity 
    {
        public string RoleName { get; set; } 
        public string Description { get; set; } 

        // relationShip
        public IList<Student> Student { get; private set; }
        public IList<Staff> Staff { get; private set; }
        public IList<Admin> Admin { get; private set; }

    }

}
