using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            /*ViewBag.Title = "Ajay";
            dynamic data = new ExpandoObject();
            data.Title = "Ajay";
            data.id = 1;
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { id = 5, Author = "This is Author" };*/

            //ViewData["Title"] = "Title";
            //ViewData["Book"]= new BookModel() { id = 5, Author = "This is Author" };
            CustomProperty = "Custom Value";
            Title = "Home page";

            return View();
        }
        public ViewResult AboutUs()  
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
