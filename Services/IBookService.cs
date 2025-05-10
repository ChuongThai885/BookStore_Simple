using BookStore.API.Services.DTO;

namespace BookStore.API.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> Get();
        Task Add(BookCreateDTO dto);
    }
}
