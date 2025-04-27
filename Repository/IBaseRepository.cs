namespace BookStore.API.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync();
        Task AddAsync(T entity);
    }
}
