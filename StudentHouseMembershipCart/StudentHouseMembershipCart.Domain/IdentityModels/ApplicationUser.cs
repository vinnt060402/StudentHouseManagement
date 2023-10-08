using Microsoft.AspNetCore.Identity;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Domain.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        

        // relationship
        public virtual Student Student { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Staff Staff { get; set; }

    }
}
