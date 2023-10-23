using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Bookstore.Models
{
    public class BookDataContext : DbContext
    {
        public DbSet<Book> Books { get; set;}
        public DbSet<Author> Authors { get; set;}

        public BookDataContext(DbContextOptions<BookDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
