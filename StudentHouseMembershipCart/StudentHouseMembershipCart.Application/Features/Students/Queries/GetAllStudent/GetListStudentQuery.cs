using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent
{
    public class GetListStudentQuery : IRequest<List<StudentResponse>>
    {

    }
}