using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ReadyToWed.Web.Mvc.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {

        public ActionResult Index()
        {
            ViewModels.BookViewModel viewModel = new ViewModels.BookViewModel(1);
            return this.View("Index", viewModel);
        }

    }
}
