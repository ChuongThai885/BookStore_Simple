using BookStore.API.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BookDbContext _dbcontext;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(BookDbContext _dbContext)
        {
            this._dbcontext = _dbContext;
            this._dbSet = _dbcontext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await this._dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await this._dbSet.AddAsync(entity);
            await _dbcontext.SaveChangesAsync(); // Fixed the issue by replacing SaveAsAsync with SaveChangesAsync  
        }
    }
}
