using FocusOnTheFamily.Domain.Interfaces;
using FocusOnTheFamily.Domain.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FocusOnTheFamily.Controllers
{
    public class HomeController : Controller
    {
        private IContentProcessor _contentProcessor;

        public HomeController(IContentProcessor contentProcessor)
        {
            _contentProcessor = contentProcessor;
        }

        // GET: Home
        public ActionResult Index()
        {
            return BuildPageView(1);
        }

        // GET: About
        public ActionResult About()
        {
            return BuildPageView(2);
        }

        // GET: About
        public ActionResult Testimonial()
        {
            return BuildPageView(3);
        }

        private ActionResult BuildPageView(int pageContentID)
        {
            Models.Content pageContent = _contentProcessor.GetPageContent(pageContentID);

            return View("Index", pageContent);
        }
    }
}