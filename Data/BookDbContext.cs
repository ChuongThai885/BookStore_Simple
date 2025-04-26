using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookDbContext : DbContext 
    {
        public BookDbContext(DbContextOptions<BookDbContext> options): base(options) { }

        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Author> Authors { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Models.Book>().ToTable("Book");
        //    modelBuilder.Entity<Models.Author>().ToTable("Author");
        //}
    }
}
