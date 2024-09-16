using Bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Core.Interfaces
{
    public interface IBookRepository
    {
        Book GetById(int id);
        IEnumerable<Book> GetAll();
        void Add(Book book);
        void Remove(int id);
    }
}
