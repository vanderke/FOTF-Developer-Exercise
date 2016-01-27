using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Db;

namespace WebApplication1.Controllers
{
    public class BooksController : ApiController
    {
        private readonly IDataModel _db;

        /// <summary>
        /// Creates a home controller with default providers
        /// </summary>
        public BooksController()
        {
            //Normally I wouldn't do this, I'd just use an IoC container like Unity but that seemed a bit complex just for this example
            _db = new DataModel();
        }

        /// <summary>
        /// Constructor allowing inversion of control via dependency injection
        /// </summary>
        /// <param name="db"></param>
        public BooksController(IDataModel db)
        {
            _db = db;
        }

        // GET api/<controller>
        public IEnumerable<Book> GetAllBooks()
        {
            return _db.Books.OrderBy(b => b.Title);
        }

        // GET api/<controller>/5
        public Book GetBook(int id)
        {
            return _db.Books.Include("Blurbs").FirstOrDefault(b => b.BookId == id);
        }
    }
}