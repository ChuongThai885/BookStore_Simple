namespace BookStore.API.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Models.Book>> Get();
        Task Add(BookCreateDTO dto);
    }
}
