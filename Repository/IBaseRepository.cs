using System.Linq.Expressions;

namespace BookStore.API.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetSet(Expression<Func<T, bool>> predicate = null);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<T?> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken));
        Task<T?> FindForUpdateAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken));
        Task AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken));
    }
}
