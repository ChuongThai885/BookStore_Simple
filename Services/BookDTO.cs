using BookStore.API.Models;

namespace BookStore.API.Services
{
    public class BookCreateDTO
    {
        public required string Title { get; set; }
        public virtual Guid? AuthorId { get; set; }
        public string? Description { get; set; }
        public IEnumerable<Guid>? GenreId { get; set; } = [];
        public int Quantity { get; set; } = 0;
        public float Price { get; set; } = 0;
    }
}
