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

    public class BookAuthorDTO
    {
        public Guid Id { get; set; } = new Guid();
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
    public class BookGenreDTO
    {
        public Guid Id { get; set; } = new Guid();
        public required string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Book> Books { get; set; } = [];
    }
    public class BookDTO
    {
        public Guid Id { get; set; } = new Guid();
        public required string Title { get; set; }
        public virtual BookAuthorDTO? Author { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<BookGenreDTO> Genre { get; set; } = [];
        public int Quantity { get; set; } = 0;
        public float Price { get; set; } = 0;
    }
}
