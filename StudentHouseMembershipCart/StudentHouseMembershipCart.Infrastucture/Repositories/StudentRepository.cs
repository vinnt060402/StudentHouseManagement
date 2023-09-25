using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Infrastucture.DatabaseContext;

namespace StudentHouseMembershipCart.Infrastucture.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }

        public async Task<Student> GetUserByEmailAndPassword(string email, string password)
        {
            var user = await _studentHouseMembershipCartDatabaseContext.Student.Where(x => x.Email == email && x.Password == password).SingleOrDefaultAsync();
            if (user == null) {
                throw new Exception("Entity not found");
            }
            return user;
        }
    }
}
