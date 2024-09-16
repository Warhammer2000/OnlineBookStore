using Bookstore.Core.Entities;
using Bookstore.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Persistence
{
    public class BookRepository : IBookRepository
    {
        private readonly BookstoreDbContext _dbContext;

        public BookRepository(BookstoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Book> GetAll()
        {
            return _dbContext.Books.AsNoTracking().ToList();
        }

        public Book GetById(int id)
        {
            return _dbContext.Books
                .AsNoTracking()
                .FirstOrDefault(book => book.Id == id) ?? new Book(0, "Неизвестно", "Неизвестно", 0);
        }


        public void Remove(int id)
        {
            var book = _dbContext.Books.Find(id);
            if(book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }
    }
}
