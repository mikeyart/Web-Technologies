using System.Web.Optimization;

namespace TopJobs.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Home Style
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/grayscale.min.css", new CssRewriteUrlTransform()));

            //Bootstrap Style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            //Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            //Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Scripts/bootstrap.min.js"));

            //jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                "~/Scripts/jquery-3.3.1.min.js"));

            //jQuery-Easing
            bundles.Add(new ScriptBundle("~/bundles/jquery-easing/js").Include(
                "~/Scripts/jquery.easing.1.3.js"));

            //Grayscale
            bundles.Add(new ScriptBundle("~/bundles/grayscale/js").Include(
                "~/Scripts/grayscale.min.js"));

        }
    }
}