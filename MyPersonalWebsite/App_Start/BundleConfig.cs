using System.Web;
using System.Web.Optimization;

namespace MyPersonalWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.unobtrusive*",
                       "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/metro").Include(
                          "~/Scripts/dialog.js",
                          "~/Scripts/dropdown.js",
                          "~/Scripts/accordion.js",
                          "~/Scripts/buttonset.js",
                          "~/Scripts/carousel.js",
                          "~/Scripts/input-control.js",
                          "~/Scripts/pagecontrol.js",
                          "~/Scripts/pagelist.js",
                          "~/Scripts/rating.js",
                          "~/Scripts/slider.js",
                          "~/Scripts/tile-slider.js",
                          "~/Scripts/tile-drag.js",
                          "~/Scripts/calendar.js"));

            bundles.Add(new ScriptBundle("~/bundles/metrojs2").Include(
                        "~/Scripts/MetroJs.lt.min.js",
                        "~/Scripts/jquery.reveal.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Commenting out the default styles            
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/modern.css",
                       "~/Content/modern-responsive.css"));

            bundles.Add(new StyleBundle("~/Content/metrocss2").Include(
                       "~/Content/MetroJs.lt.css",
                       "~/Content/reveal.css"));

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
        }
    }
}
