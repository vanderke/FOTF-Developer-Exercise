using System;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace WebAPIBookStore.Models
{
    public interface IRepository
    {
        string MetaData {get;}

        SaveResult SaveChanges(JObject saveBundle);

        IQueryable<Book> Books();
        IQueryable<Order> Orders();
    }
}
