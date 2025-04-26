using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book : ControllerBase
    {
        public static readonly List<Models.Book> books = new()
{
    new Models.Book
    {
        Id = Guid.NewGuid(),
        Title = "Clean Code",
        Author = new Models.Author
        {
            Id = Guid.NewGuid(),
            Name = "Robert C. Martin",
            Description = "Software engineer and author"
        },
        Description = "A Handbook of Agile Software Craftsmanship",
        Genre = "Programming",
        Quantity = 10,
        Price = 29.99f
    },
    new Models.Book
    {
        Id = Guid.NewGuid(),
        Title = "The Pragmatic Programmer",
        Author = new Models.Author
        {
            Id = Guid.NewGuid(),
            Name = "Andrew Hunt",
            Description = "Author and programmer"
        },
        Description = "Your Journey to Mastery",
        Genre = "Software Development",
        Quantity = 7,
        Price = 34.50f
    }
};

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(books);
        }
    }
}
