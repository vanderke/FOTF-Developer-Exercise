using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using Website101.Models;
using Website101.Infrastructure;
using Website101.Data;

namespace Website101.Controllers
{
  public class BookController : Controller {

    // GET: Book/Chapter/1
    public ActionResult Chapter( int id = 1 ) {
      Book<Chapter> book = new Book<Models.Chapter>();
      Models.Chapter chapter = book.GetChapter( id );
      return View( chapter );
    }

    //GET: Book/List
    public JsonResult List() {
      JsonResult result = new JsonResult();
      Book<Chapter> book = new Book<Models.Chapter>();
      object data = new { chapters = book };
      return Json( data, JsonRequestBehavior.AllowGet );
    }
  }
}