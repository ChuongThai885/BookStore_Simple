using BookStore.API.Services;
using BookStore.API.Services.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorServices _services;
        public AuthorController(IAuthorServices _services)
        {
            this._services = _services;
        }
        [HttpGet("author/getall")]
        public async Task<IEnumerable<AuthorDTO>> Get()
        {
            return await _services.Get();
        }
        [HttpPost("author/add")]
        public async Task Add(AuthorCreateDTO author)
        {
            await _services.Add(author);
        }
       
    }
}
