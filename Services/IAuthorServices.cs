using BookStore.API.Services.DTO;

namespace BookStore.API.Services
{
    public interface IAuthorServices
    {
        Task<IEnumerable<AuthorDTO>> Get();
        Task Add(AuthorCreateDTO data);
    }
}
