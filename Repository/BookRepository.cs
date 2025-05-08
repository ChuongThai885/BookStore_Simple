using BookStore.API.Data;

namespace BookStore.API.Repository
{
    public class BookRepository: BaseRepository<Models.Book>, IBookRepository
    {
        public BookRepository(BookDbContext context) : base(context) { }
    }
}
