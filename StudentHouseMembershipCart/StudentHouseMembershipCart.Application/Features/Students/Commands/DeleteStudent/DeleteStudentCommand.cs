using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
