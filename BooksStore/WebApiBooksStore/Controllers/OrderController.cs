using WebApiBooksStore.Models;
using System.Linq;
using System.Web.Http;

namespace WebApiBooksStore.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IRepository _repo;

        public OrderController(IRepository repo)
        {
            _repo = repo;
        }

        public IQueryable<Order> Get()
        {
                return _repo.GetAllOrders();
        }

        public IQueryable<Order> Get(bool includeDetails)
    {
        var query = includeDetails ? _repo.GetAllOrdersWithDetails() : _repo.GetAllOrders();

        return query;
    }


        public Order Get(int id)
        {
            return _repo.GetOrder(id);
        }
    }
}
