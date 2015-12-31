using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website101.Models;

namespace Website101.Controllers {
  public class HomeController : Controller {

    // GET: Home
    public ActionResult Index() {
      Book<Chapter> model = new Book<Chapter>();
      return View( model );
    }
  }
}