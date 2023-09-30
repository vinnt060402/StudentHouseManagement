using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Common;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseAuditableEntity
    {
        protected readonly StudentHouseMembershipCartDatabaseContext _studentHouseMembershipCartDatabaseContext;
        public GenericRepository(StudentHouseMembershipCartDatabaseContext context)
        {
            this._studentHouseMembershipCartDatabaseContext = context;
        }
        public async Task CreateAsync(T entity)
        {
            await _studentHouseMembershipCartDatabaseContext.AddAsync(entity);
            await _studentHouseMembershipCartDatabaseContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            var findIdDelete = await _studentHouseMembershipCartDatabaseContext.Set<T>().AsNoTracking().Where(q => q.Id == entity.Id).FirstOrDefaultAsync();
            if (findIdDelete == null || findIdDelete.IsDelete)
            {
                throw new Exception("Not Found");
            }
            findIdDelete.IsDelete = true;
            _studentHouseMembershipCartDatabaseContext.Set<T>().Update(findIdDelete);
            await _studentHouseMembershipCartDatabaseContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            return await _studentHouseMembershipCartDatabaseContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _studentHouseMembershipCartDatabaseContext.Set<T>().AsNoTracking().Where(q => q.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _studentHouseMembershipCartDatabaseContext.Update(entity);
            _studentHouseMembershipCartDatabaseContext.Entry(entity).State = EntityState.Modified;
            await _studentHouseMembershipCartDatabaseContext.SaveChangesAsync();
        }
    }
}
