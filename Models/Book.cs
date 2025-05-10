using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public required string Title { get; set; }
        public virtual Author? Author { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Genre> Genre { get; set; } = [];
        public int Quantity { get; set; } = 0;
        public float Price { get; set; } = 0;
    }
}
