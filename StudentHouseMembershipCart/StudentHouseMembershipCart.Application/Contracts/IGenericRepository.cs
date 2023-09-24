using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Application.Contracts
{
    public interface IGenericRepository<T> where T : BaseAuditableEntity
    {
        Task<IReadOnlyList<T>> GetAsync();
        Task<T> GetByIdAsync(Guid id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
