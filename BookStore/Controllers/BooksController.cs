using Bookstore.Core.Entities;
using Bookstore.Core.Interfaces;
using BookStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace BookStore.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly AddBookUseCase _addBookUseCase;
        private readonly IBookRepository _bookRepository;

        public BooksController(AddBookUseCase addBookUseCase, IBookRepository bookRepository)
        {
            _addBookUseCase = addBookUseCase;
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _bookRepository.GetAll();
            return Ok(books);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            _addBookUseCase.Execute(book);
            return Ok();
        }
    }
}
