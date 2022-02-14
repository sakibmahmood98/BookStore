using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        /*public BookContext() : base("name=DefaultConnection")
        {
        }*/
        public DbSet<Book> Books { get; set; }
    }
}
