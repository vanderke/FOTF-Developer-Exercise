using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace ReadyToWed.Web.Configuration
{
    public sealed class BundleConfiguration
    {
        private BundleConfiguration()
        {
           
        }

        public static void Configure(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
#if DEBUG
            BundleTable.EnableOptimizations = false;
#endif
            RegisterStyleBundles(bundles);
            RegisterScriptBundles(bundles);

            //bundle scripts are already minimized, so improve
            //  performance by clearing the transforms that would minimize 
            //  the scripts again
            foreach (Bundle bundle in bundles)
            {
                bundle.Transforms.Clear();
            }
        }

        public static string RenderCssBundleHtml()
        {
            System.Text.StringBuilder sbHtml = new System.Text.StringBuilder();

            foreach (StyleBundle bundle in BundleTable.Bundles.OfType<StyleBundle>())
            {
                sbHtml.Append(System.Web.Optimization.Styles.Render(bundle.Path).ToHtmlString());
            }

            return sbHtml.ToString();
        }

        public static string RenderJsBundleHtml()
        {
            System.Text.StringBuilder sbHtml = new System.Text.StringBuilder();

            foreach (ScriptBundle bundle in BundleTable.Bundles.OfType<ScriptBundle>())
            {
                sbHtml.Append(System.Web.Optimization.Styles.Render(bundle.Path).ToHtmlString());
            }

            return sbHtml.ToString();
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/bootstrap/css").Include("~/content/*.css"));
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/content/scripts/jquery/js").Include("~/scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/content/scripts/bootstrap/js").Include("~/scripts/bootstrap.js"));
        }

    }
}
