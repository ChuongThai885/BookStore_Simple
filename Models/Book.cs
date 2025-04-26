namespace BookStore.API.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual Author Author { get; set; }
        public string Description { get; set; }
        public  string Genre { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

    }
}
