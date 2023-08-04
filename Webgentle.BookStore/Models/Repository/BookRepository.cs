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
                new BookModel() {id=1, Title="MVC", Author="Anil", Description="This is MVC in ASP.NET CORE", Category="Dot Net", 
                    Language="English", TotalPages= 100},
                new BookModel() {id=2, Title="C#", Author="Ajay",Description="This is C# Primary lanuage", Category="Dot Net",
                    Language="English", TotalPages= 100},
                new BookModel() {id=3, Title="ASP.NET", Author="Geeta",Description="This is Pure ASP.NET Webforms", Category="Dot Net",
                    Language="English", TotalPages= 100},
                new BookModel() {id=4, Title="Java", Author="Amruta", Description="Java is OOPS based", Category="Dot Net",
                    Language="English", TotalPages= 100},
                new BookModel() {id=5, Title="Python", Author="Sunny", Description="java is replaced by python", Category="Dot Net",
                    Language="English", TotalPages= 100},
            };
        }
    }
}
