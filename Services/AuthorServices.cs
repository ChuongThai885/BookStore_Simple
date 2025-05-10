using AutoMapper;
using BookStore.API.Repository;
using BookStore.API.Services.DTO;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Services
{
    public class AuthorServices: IAuthorServices
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _repository;
        public AuthorServices(IMapper mapper,IAuthorRepository _repository)
        {
            this._mapper = mapper;
            this._repository = _repository;
        }

        public async Task<IEnumerable<AuthorDTO>> Get()
        {
            var query = await _repository.GetSet().Include(item => item.Books).ToListAsync();
            var result = this._mapper.Map<IEnumerable<AuthorDTO>>(query);
            return result;
        }
        public async Task Add(AuthorCreateDTO dto)
        {
            var author = this._mapper.Map<Models.Author>(dto);
            await _repository.AddAsync(author);
        }
    }
}
