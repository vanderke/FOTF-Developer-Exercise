using FocusOnTheFamily.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FocusOnTheFamily.Controllers
{
    public class ProductController : Controller
    {
        private IProductProcessor _productProcessor;

        public ProductController(IProductProcessor productProcessor)
        {
            _productProcessor = productProcessor;
        }

        // GET: Product
        public ActionResult Index()
        {
            List<Models.Product> products = _productProcessor.GetProducts();

            return View("Index", products);
        }

        // GET: Detail
        public ActionResult Detail(System.Guid? id)
        {
            Models.Product productDTO = _productProcessor.GetProduct(id);
            List<Models.Product> products = new List<Models.Product>();
            products.Add(productDTO);

            return View("Index", products);
        }
    }
}