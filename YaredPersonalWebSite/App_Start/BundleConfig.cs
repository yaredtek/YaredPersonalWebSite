using System.Web;
using System.Web.Optimization;

namespace YaredPersonalWebSite
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/UI/assets/js/modernizr.custom.js"));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/UI/assets/js/jquery-1.11.1.min.js",
                        "~/UI/assets/bootstrap/js/bootstrap.min.js",
                        "~/UI/assets/js/jquery.parallax-1.1.3.js",
                        "~/UI/assets/js/imagesloaded.pkgd.js",
                        "~/UI/assets/js/jquery.sticky.js",
                        "~/UI/assets/js/smoothscroll.js",
                        "~/UI/assets/js/wow.min.js",
                        "~/UI/assets/js/jquery.easypiechart.js",
                        "~/UI/assets/js/waypoints.min.js",
                        "~/UI/assets/js/jquery.cbpQTRotator.js",
                        "~/UI/assets/js/custom.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/UI/assets/bootstrap/css/css").Include("~/UI/assets/bootstrap/css/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/UI/assets/css/css").Include(
                        "~/UI/assets/css/font-awesome.min.css",
                        "~/UI/assets/css/simple-line-icons.css",
                        "~/UI/assets/css/animate.css",
                        "~/UI/assets/css/style.css"));

            bundles.Add(new StyleBundle("~/UI/assets/css/Custom/css").Include("~/UI/assets/css/Custom/login.css"));


        }
    }
}