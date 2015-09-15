using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ReadyToWed.Web.Mvc.Html
{
    public static class PageExtensions
    {

        public static MvcHtmlString PageCssBundles(this HtmlHelper htmlHelper)
        {
            string html = Configuration.BundleConfiguration.RenderCssBundleHtml();
            return new MvcHtmlString(html); 
        }

        public static MvcHtmlString PageJsBundles(this HtmlHelper htmlHelper)
        {
            string html = Configuration.BundleConfiguration.RenderJsBundleHtml();
            return new MvcHtmlString(html);
        }

    }
}
