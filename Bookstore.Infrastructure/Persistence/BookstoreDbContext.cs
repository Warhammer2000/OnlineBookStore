using Bookstore.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Bookstore.Infrastructure.Persistence
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {
        }
    }
}
