using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS3 The Complete Manual - Author Name Book");
            books.Add("HTML5 & CSS Responsive web Design cookbook - Author Name Book 2");
            books.Add("Professional ASP.NET MVC5 - Author Name Book 2");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The Complete Manual", "Author Name Book 1", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3egfEcqpoHfgfhIU_3ztvulREW5CZDZp9fQ&usqp=CAU"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web Design cookbook", "Author Name Book 2", "https://i.pinimg.com/236x/f0/e9/74/f0e974ec44ac81dbfd88b665b0c4ebd0--html.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQk42hqvW2OWgUgIcI47NYUTRQJC_Np5heTHw&usqp=CAU"));
            return View(books);
        }
        public ActionResult EditBook(int id, string Title, string Author, string ImageCover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The Complete Manual", "Author Name Book 1", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3egfEcqpoHfgfhIU_3ztvulREW5CZDZp9fQ&usqp=CAU"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web Design cookbook", "Author Name Book 2", "https://i.pinimg.com/236x/f0/e9/74/f0e974ec44ac81dbfd88b665b0c4ebd0--html.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQk42hqvW2OWgUgIcI47NYUTRQJC_Np5heTHw&usqp=CAU"));
            Book book = new Book();
            if(id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = Title;
                    b.Author = Author;
                    b.ImageCover = ImageCover;
                    break;
                }
            }
            return View("ListBookModel",books);
        }
    }
}