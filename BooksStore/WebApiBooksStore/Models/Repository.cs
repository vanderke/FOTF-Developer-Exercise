using System.Linq;
using Breeze.ContextProvider.EF6;

namespace WebApiBooksStore.Models
{
    public class Repository:IRepository
    {
        private readonly EFContextProvider<WebApiBooksStoreContext> _contextProvider = new EFContextProvider<WebApiBooksStoreContext>();

        public string MetaData
        {
            get { return _contextProvider.Metadata(); }
        }

        public Breeze.ContextProvider.SaveResult SaveChanges(Newtonsoft.Json.Linq.JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        public IQueryable<Book> Books()
        {
            return _contextProvider.Context.Books;
        }

        public IQueryable<Order> Orders()
        {
            return _contextProvider.Context.Orders;
        }
    }
}