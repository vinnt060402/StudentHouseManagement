using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries
{
    public class StaffResponse
    {
        public StaffData? staffData { get; set; }
        public ApplicationStaff? inforOfStaffData { get; set; }
    }
    public class StaffData
    {
        public Guid Id { get; set; }
        public string? staffName { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public string? ApplicationUserId { get; set; }
        public DateTime? Created { get; set; }
        public bool IsDelete { get; set; }
    }
    public class ApplicationStaff
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

}