using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Contracts.Persistance
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> GetUserByEmailAndPassword(string email, string password);
    }
}
