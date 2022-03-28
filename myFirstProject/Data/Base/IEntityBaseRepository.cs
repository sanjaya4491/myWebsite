using System.Linq.Expressions;

namespace myFirstProject.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);

        Task DeleteAsync(int id);
    }
}
