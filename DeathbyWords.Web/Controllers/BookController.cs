using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeathByWords.Core.Models;
using DeathByWords.Web.Helpers;
using DeathbyWords.Core.Services;

namespace DeathByWords.Web.Controllers
{
    public class BookController : Controller
    {
        

        public ActionResult Events()
        {
            List<Book> books = GoogleBooksService.getCurrent();
            ViewBag.ListofBooks = books;
            return View();
        }

        public ActionResult Pastreads()
        {
            List<Book> books = GoogleBooksService.getRead();
            ViewBag.ListofBooks = books;
            return View();
        }

    }
}
