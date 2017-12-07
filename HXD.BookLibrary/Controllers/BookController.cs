using HXD.BookLibrary.Models;
using HXD.BookLibrary.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HXD.BookLibrary.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index(int pageIndex = 1, int pageSize = 20)
        {
            List<Book> books = GetBooks();
            BookListViewModel bookListViewModel = new BookListViewModel();
            PageHelper pageHelper = new PageHelper();
            pageHelper.TotalCount = books.Count;
            pageHelper.CurrentPage = pageIndex;
            pageHelper.PageSize = pageSize;
            pageHelper.RecordCount = (int)Math.Ceiling(((double)pageHelper.TotalCount / pageHelper.PageSize));
            bookListViewModel.PageHelper = pageHelper;
            bookListViewModel.Books = books.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return View(bookListViewModel);
        }
        private List<Book> GetBooks(int length = 56)
        {
            List<Book> books = new List<Book>();
            for (int i = 1; i <= length; i++)
            {
                books.Add(new Book { Id = i, Name = "哈哈" + i.ToString(), Author = "冬晓冬" + i.ToString() });
            }
            return books;
        }
    }
}