using FocusOnTheFamily.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FocusOnTheFamily.Controllers
{
    public class AdminController : Controller
    {
        IContentProcessor _contentProcessor;
        IProductProcessor _productProcessor;
        IImageProcessor _imageProcessor;

        public AdminController(IContentProcessor contentProcessor, IProductProcessor productProcessor, IImageProcessor imageProcessor)
        {
            _contentProcessor = contentProcessor;
            _productProcessor = productProcessor;
            _imageProcessor = imageProcessor;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Content
        public ActionResult ListContents()
        {
            List<Models.Content> contents = _contentProcessor.GetContents();

            return View("Content", contents);
        }

        public ActionResult Content(int id)
        {
            ViewModels.EditContentVM contentViewModel = new ViewModels.EditContentVM();

            contentViewModel.pageContent = _contentProcessor.GetPageContent(id);
            contentViewModel.Products = _productProcessor.GetProducts();
            contentViewModel.Images = _imageProcessor.GetImages();

            return View("EditContent", contentViewModel);
        }

        [HttpPost]
        public ActionResult UpdateContentTitle(Models.Content content)
        {
            _contentProcessor.UpdateContent(content);

            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult DeleteContentStory(int ContentStoryID)
        {
            _contentProcessor.DeleteContentStory(ContentStoryID);

            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult UpdateContentStory(Models.ContentStory story)
        {
            _contentProcessor.UpdateContentStory(story);

            return Json(new { success = true });
        }

        [HttpGet]
        public ActionResult ListProducts()
        {
            List<Models.Product> products = _productProcessor.GetProducts();

            return View("ListProducts", products);
        }

        [HttpGet]
        public ActionResult EditProduct(System.Guid id)
        {
            ViewModels.EditProductVM productViewModel = new ViewModels.EditProductVM();

            productViewModel.product = new Models.Product();
            if(id != System.Guid.Empty)
                productViewModel.product = _productProcessor.GetProduct(id);

            productViewModel.images = _imageProcessor.GetImages();

            return View("EditProduct", productViewModel);
        }

        [HttpPost]
        public ActionResult DeleteProductDetail(int ProductDetailID)
        {
            _productProcessor.DeleteProductDetail(ProductDetailID);

            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult UpdateProductDetail(Models.ProductDetail productDetail)
        {
            _productProcessor.UpdateProductDetail(productDetail);

            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult UpdateProduct(Models.Product product)
        {
            _productProcessor.UpdateProduct(product);

            return Json(new { success = true });
        }
    }
}