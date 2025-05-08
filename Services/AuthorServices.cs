using BookStore.API.Repository;

namespace BookStore.API.Services
{
    public class AuthorServices: IAuthorServices
    {
        private readonly IAuthorRepository _repository;
        public AuthorServices(IAuthorRepository _repository)
        {
            this._repository = _repository;
        }

        public async Task<IEnumerable<Models.Author>> Get()
        {
            return await _repository.GetAsync();
        }
        public async Task Add(Models.Author data)
        {
            await _repository.AddAsync(data);
        }
    }
}
