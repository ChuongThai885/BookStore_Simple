namespace BookStore.API.Services
{
    public interface IAuthorServices
    {
        Task<IEnumerable<Models.Author>> Get();
        Task Add(Models.Author data);
    }
}
