using System.Web;
using System.Web.Optimization;

namespace FindEducators
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Template").Include(
                    "~/Content/Template/css/custom.css",
                    "~/Content/Template/css/bootstrap.css",
                    "~/Content/Template/css/color.css",
                    "~/Content/Template/css/responsive.css",
                    "~/Content/Template/css/owl.carousel.css",
                    "~/Content/Template/css/font-awesome.min.css",
                    "~/Content/Template/css/jquery.mCustomScrollbar.css",
                    "~/Content/Template/css/feCustom.css",
                    "~/Content/Template/images/favicon.ico"
                ));

            bundles.Add(new ScriptBundle("~/Bundles/Template").Include(
                
                "~/Content/Template/js/jquery-1.11.3.min.js",
                "~/Content/Template/js/bootstrap.min.js",
                "~/Content/Template/js/owl.carousel.min.js",
                "~/Content/Template/js/jquery.velocity.min.js",
                "~/Content/Template/js/jquery.kenburnsy.js",
                "~/Content/Template/js/jquery.mCustomScrollbar.concat.min.js",
                "~/Content/Template/js/query.noconflict.js",
                "~/Content/Template/js/theme-scripts.js",
                "~/Content/Template/js/form.js",
                "~/Content/Template/js/custom.js"
                
                ));


            bundles.Add(new StyleBundle("~/Content/Admin").Include(

                "~/content/admin/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                "~/content/admin/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                "~/content/admin/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                "~/content/admin/assets/global/plugins/uniform/css/uniform.default.css",
                "~/content/admin/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                "~/content/admin/assets/global/plugins/bootstrap-daterangepicker/daterangepicker-bs3.css",
                "~/content/admin/assets/global/plugins/fullcalendar/fullcalendar.min.css",
                "~/content/admin/assets/global/plugins/jqvmap/jqvmap/jqvmap.css",
                "~/content/admin/assets/admin/pages/css/tasks.css",
                "~/content/admin/assets/global/css/components.css",
                "~/content/admin/assets/global/css/plugins.css",
                "~/content/admin/assets/admin/layout/css/layout.css",
                "~/content/admin/assets/admin/layout/css/themes/darkblue.css",
                "~/content/admin/assets/admin/layout/css/custom.css"

                ));

            bundles.Add(new ScriptBundle("~/Bundles/Admin").Include(
                "~/content/admin/assets/global/plugins/jquery.min.js",
                "~/content/admin/assets/global/plugins/jquery-migrate.min.js",
                "~/content/admin/assets/global/plugins/jquery-ui/jquery-ui-1.10.3.custom.min.js",
                "~/content/admin/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                "~/content/admin/assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                "~/content/admin/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/content/admin/assets/global/plugins/jquery.blockui.min.js",
                "~/content/admin/assets/global/plugins/jquery.cokie.min.js",
                "~/content/admin/assets/global/plugins/uniform/jquery.uniform.min.js",
                "~/content/admin/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                "~/content/admin/assets/global/plugins/flot/jquery.flot.min.js",
                "~/content/admin/assets/global/plugins/flot/jquery.flot.resize.min.js",
                "~/content/admin/assets/global/plugins/flot/jquery.flot.categories.min.js",
                "~/content/admin/assets/global/plugins/jquery.pulsate.min.js",
                "~/content/admin/assets/global/plugins/bootstrap-daterangepicker/moment.min.js",
                "~/content/admin/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.js",
                "~/content/admin/assets/global/plugins/fullcalendar/fullcalendar.min.js",
                "~/content/admin/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js",
                "~/content/admin/assets/global/plugins/jquery.sparkline.min.js",
                "~/content/admin/assets/global/scripts/metronic.js",
                "~/content/admin/assets/admin/layout/scripts/layout.js",
                "~/content/admin/assets/admin/layout/scripts/quick-sidebar.js",
                "~/content/admin/assets/admin/layout/scripts/demo.js",
                "~/content/admin/assets/admin/pages/scripts/index.js",
                "~/content/admin/assets/admin/pages/scripts/tasks.js"
                ));

            //bundles.Add(new StyleBundle("~/Content/AdminLogin").Include(
            //    "~/content/admin/template/global/plugins/font-awesome/css/font-awesome.min.css", 
            //    "~/content/admin/template/global/plugins/simple-line-icons/simple-line-icons.min.css" ,
            //    "~/content/admin/template/global/plugins/bootstrap/css/bootstrap.min.css" ,
            //    "~/content/admin/template/global/plugins/uniform/css/uniform.default.css" ,
            //    "~/content/admin/template/global/plugins/select2/select2.css" ,
            //    "~/content/admin/template/admin/pages/css/login-soft.css", 
            //    "~/content/admin/template/global/css/components.css" ,
            //    "~/content/admin/template/global/css/plugins.css", 
            //    "~/content/admin/template/layout/css/layout.css",
            //    "~/content/admin/template/layout/css/themes/darkblue.css" ,
            //    "~/content/admin/template/layout/css/custom.css" 
            //    ));

            bundles.Add(new StyleBundle("~/Content/AdminLogin").Include(
               "~/content/admin/assets/global/plugins/font-awesome/css/font-awesome.min.css",
               "~/content/admin/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
               "~/content/admin/assets/global/plugins/bootstrap/css/bootstrap.min.css",
               "~/content/admin/assets/global/plugins/uniform/css/uniform.default.css",
               "~/content/admin/assets/global/plugins/select2/select2.css",
               "~/content/admin/assets/admin/pages/css/login-soft.css",
               "~/content/admin/assets/global/css/components.css",
               "~/content/admin/assets/global/css/plugins.css",
               "~/content/admin/assets/admin/layout/css/layout.css",
               "~/content/admin/assets/admin/layout/css/themes/darkblue.css",
               "~/content/adminassets/admin/layout/css/custom.css"

            ));
            bundles.Add(new ScriptBundle("~/Bundles/AdminLogin").Include(

               "~/content/admin/assets/global/plugins/jquery.min.js",
                "~/content/admin/assets/global/plugins/bootstrap/js/bootstrap.min.js" ,
                "~/content/admin/assets/global/plugins/jquery.blockui.min.js" ,
                "~/content/admin/assets/global/plugins/uniform/jquery.uniform.min.js" ,
                "~/content/admin/assets/global/plugins/jquery.cokie.min.js" ,
                "~/content/admin/assets/global/plugins/backstretch/jquery.backstretch.min.js",
                "~/content/admin/assets/global/plugins/select2/select2.min.js",
                "~/content/adminassets/global/scripts/metronic.js",
                "~/content/adminassets/admin/layout/scripts/layout.js" ,
                "~/content/adminassets/admin/layout/scripts/demo.js" ,
                "~/content/adminassets/admin/pages/scripts/login-soft.js"

                ));



        
        }


    }
}
