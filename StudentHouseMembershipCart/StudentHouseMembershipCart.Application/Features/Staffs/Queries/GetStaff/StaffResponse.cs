using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff
{
    public class StaffResponse
    {
        public Staff? staffData { get; set; }
        public ApplicationUser? inforOfStaffData { get; set; }
    }
}
