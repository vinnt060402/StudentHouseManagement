using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<StudentDto>
    {
        public Guid Id { get; set; }
    }
}