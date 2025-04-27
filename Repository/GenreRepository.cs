using BookStore.API.Data;

namespace BookStore.API.Repository
{
    public class GenreRepository : BaseRepository<Models.Genre>, IGenreRepository
    {
        public GenreRepository(BookDbContext context) : base(context) { }
    }
}
