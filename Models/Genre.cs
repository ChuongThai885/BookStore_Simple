using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public required string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Book> Books { get; set; } = [];
    }
}
