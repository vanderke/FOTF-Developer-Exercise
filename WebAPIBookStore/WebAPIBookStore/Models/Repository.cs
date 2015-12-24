using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.ContextProvider.EF6;

namespace WebAPIBookStore.Models
{
    public class Repository : WebAPIBookStore.Models.IRepository
    {
        private readonly EFContextProvider<WebAPIBookStoreContext> _contextProvider = new EFContextProvider<WebAPIBookStoreContext> ();

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