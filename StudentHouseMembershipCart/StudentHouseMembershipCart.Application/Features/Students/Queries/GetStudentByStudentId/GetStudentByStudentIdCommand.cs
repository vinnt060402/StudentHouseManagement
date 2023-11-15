using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId
{
    public class GetStudentByStudentIdCommand : IRequest<StudentDataNew>
    {
        public Guid StudentId { get; set; }
    }
}