using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string StudentName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        
        public int RoleId { get; set; }
        
        public Guid FeedbackId { get; set; }

        public DateTime Created { get; set; }

        public string? CreateBy { get; set; }

        public DateTime? LastModified { get; set; }

        public string? LastModifiedBy { get; set; }

        public bool IsDelete { get; set; }
    }
}
