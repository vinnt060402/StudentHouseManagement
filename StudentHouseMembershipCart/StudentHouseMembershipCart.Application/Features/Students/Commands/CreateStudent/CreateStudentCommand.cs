using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommand : IRequest<Guid>
    {
        public string StudentName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
