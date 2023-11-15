using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommand : IRequest<Unit>
    {
        public Guid StudentId { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public DateTime Birthday { get; set; }
    }
}