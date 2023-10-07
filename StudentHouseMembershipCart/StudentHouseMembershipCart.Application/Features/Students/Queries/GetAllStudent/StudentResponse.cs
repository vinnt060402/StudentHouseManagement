using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent
{
    public class StudentResponse
    {
        public Student? StudentTableData { get; set; }
        public ApplicationUser? ApplicationUserTableData { get; set; }
    }
}
