using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyToWed.Web.WebApi.Controllers
{
    [System.Web.Http.RoutePrefix("api/books")]
    public class BookController : System.Web.Http.ApiController
    {

        [System.Web.Http.HttpGet]
        public async Task<Models.BookModel> GetBook(int id)
        {
            Maybe<Models.BookModel> model = await Data.ModelReaderManager.Current.ReadAsync<Models.BookModel>(id);
            if (model.Any())
            {
                return model.Single();
            }
            return new Models.BookModel();
        }

    }
}
