using BookStore.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _service;
        public BookController(IBookService service)
        {
            this._service = service;
        }

        [HttpGet("books/getall")]
        public async Task<IEnumerable<Models.Book>> Get()
        {
            return await this._service.Get();
        }
        [HttpPost("books/create")]
        public async Task Add(BookCreateDTO dto)
        {
            await _service.Add(dto);
        }
    }
}
