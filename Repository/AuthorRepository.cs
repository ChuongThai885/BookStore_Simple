using BookStore.API.Data;

namespace BookStore.API.Repository
{
    public class AuthorRepository : BaseRepository<Models.Author>, IAuthorRepository
    {
        public AuthorRepository(BookDbContext context) : base(context) { }
    }
}
