using System.Web;
using System.Web.Optimization;

namespace ConsultaMEdica
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/cube").Include(
                      "~/Content/js/jquery.nanoscroller.min.js",
                      "~/Content/js/demo.js",
                      "~/Content/js/scripts.js",
                      "~/Content/js/pace.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap/bootstrap.min.css",
                      "~/Content/css/libs/font-awesome.css",
                      "~/Content/css/libs/nanoscroller.css",
                      "~/Content/css/compiled/theme_styles.css",
                      "~/Content/css/libs/jquery-jvectormap-1.2.2.css",
                      "~/Content/css/libs/weather-icons.css",
                      "~/Content/css/libs/daterangepicker.css",
                      "~/Content/site.css"));
        }
    }
}
