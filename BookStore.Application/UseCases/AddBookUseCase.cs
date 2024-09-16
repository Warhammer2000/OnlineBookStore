using Bookstore.Core.Entities;
using Bookstore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.UseCases
{
    public class AddBookUseCase
    {
        private readonly IBookRepository _bookRepository;

        public AddBookUseCase(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Execute(Book book)
        {
            _bookRepository.Add(book);
        }
    }
}
