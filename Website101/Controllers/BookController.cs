using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website101.Models;

namespace Website101.Controllers
{
  public class BookController : Controller {

    // GET: Book
    public ActionResult Chapter( int id = 1 ) {
      Book<Chapter> book = new Book<Models.Chapter>();
      Models.Chapter chapter = book.GetChapter( id );
      return View( chapter );
    }
  }
}