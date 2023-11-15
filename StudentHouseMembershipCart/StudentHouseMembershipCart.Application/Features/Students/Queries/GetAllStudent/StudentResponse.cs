using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent
{
    public class StudentResponse
    {
        public Student? StudentTableData { get; set; }
        public ApplicationUser? ApplicationUserTableData { get; set; }
    }
}