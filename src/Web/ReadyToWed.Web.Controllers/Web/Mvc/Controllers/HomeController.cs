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

        public async Task<ActionResult> Index()
        {
            ViewModels.BookViewModel viewModel;
            Maybe<Models.BookModel> book = await Data.ModelReaderManager.Current.ReadAsync<Models.BookModel>(1);
            if (book.Any())
            {
                viewModel = new ViewModels.BookViewModel(book.Single());
            }
            else
            {
                viewModel = new ViewModels.BookViewModel(new Models.BookModel());
            }
            return this.View("Index", viewModel);
        }

    }
}
