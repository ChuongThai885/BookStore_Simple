using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok();
        }
    }
}
