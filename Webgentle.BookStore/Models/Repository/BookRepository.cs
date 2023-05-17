using System.Collections.Generic;
using System.Linq;

namespace Webgentle.BookStore.Models.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorname)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {id=1, Title="Ajay", Author="Anil"},
                new BookModel() {id=2, Title="Ajay1", Author="Anil1"},
                new BookModel() {id=3, Title="Ajay2", Author="Anil2"},
            };
        }
    }
}
