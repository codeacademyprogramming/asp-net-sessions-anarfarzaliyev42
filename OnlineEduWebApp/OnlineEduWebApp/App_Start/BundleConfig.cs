using System.Web;
using System.Web.Optimization;

namespace OnlineEduWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                      "~/Scripts/jquery.validate*"));
            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/owl.carousel.min.css",
                      "~/assets/css/slicknav.css",
                      "~/assets/css/flaticon.css",
                     "~/assets/css/gijgo.css",
                     "~/assets/css/animate.min.css",
                     "~/assets/css/magnific-popup.css",
                     "~/assets/css/fontawesome-all.min.css",
                     "~/assets/css/themify-icons.css",
                     "~/assets/css/slick.css",
                     "~/assets/css/nice-select.css",
                     "~/assets/css/style.css"));
            bundles.Add(new ScriptBundle("~/bundles/jquery/popper/bootstrap").Include(
                       "~/assets/js/vendor/jquery-1.12.4.min.js",
                       "~/assets/js/popper.min.js",
                       "~/assets/js/bootstrap.min.js"
                       ));
            bundles.Add(new ScriptBundle("~/bundles/Owl-Carousel").Include(
                      "~/assets/js/owl.carousel.min.js",
                      "~/assets/js/slick.min.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/Animated-HeadLin").Include(
                     "~/assets/js/wow.min.js",
                     "~/assets/js/animated.headline.js",
                     "~/assets/js/jquery.magnific-popup.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/Nice-select-sticky").Include(
                    "~/assets/js/jquery.nice-select.min.js",
                    "~/assets/js/jquery.sticky.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/contact-js").Include(
                   "~/assets/js/contact.js",
                   "~/assets/js/jquery.form.js",
                   "~/assets/js/jquery.validate.min.js",
                   "~/assets/js/mail-script.js",
                   "~/assets/js/jquery.ajaxchimp.min.js"
                   ));



        }
    }
}
