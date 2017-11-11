using BookShop_Domain.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop_WebUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository Repository;

        public BookController(IBookRepository BookRep)
        {
            Repository = BookRep;
        }


        public ViewResult List()
        {

            return View(Repository.Books);
        }
    }
}