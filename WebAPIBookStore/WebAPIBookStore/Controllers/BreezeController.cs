using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Breeze.WebApi2;
using WebAPIBookStore.Models;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;

namespace WebAPIBookStore.Controllers 
{
    [BreezeController]
    public class BreezeController : ApiController
    {
        private readonly IRepository _repo;

        public BreezeController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public string MetaData()
        {
            return _repo.MetaData;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _repo.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<Book> Books()
        {
            return _repo.Books();
        }

        [HttpGet]
        public IQueryable<Order> Orders()
        {
            return _repo.Orders();
        }

    }
}