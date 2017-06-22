using System.Web.Optimization;

namespace Sod.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                "~/Scripts/jquery-{version}.js"
                ));
            bundles.Add(new ScriptBundle("~/js/index").Include(
                "~/js/index.js"
            ));
            bundles.Add(new ScriptBundle("~/js/main").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/assets/tipped/js/tipped.js",
                "~/js/main.js"));

            bundles.Add(new StyleBundle("~/css/site").Include(
                      "~/content/bootstrap.css",
                      "~/css/theme.css",
                      "~/css/font-awesome.min.css",
                      "~/css/site.css",
                      "~/css/mobile.css"));
            BundleTable.EnableOptimizations = true;
        }

    }
}

