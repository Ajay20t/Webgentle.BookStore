using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Models.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository(); 
        }
        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data =  _bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> searchBook(string bookname, string Authorname) 
        {
            return _bookRepository.SearchBook(bookname, Authorname);
        }
    }
}
