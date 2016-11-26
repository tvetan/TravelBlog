using System.Collections.Generic;
using System.Web.Optimization;

namespace TravelBlog.Bundle
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddStyles(bundles);

            AddScripts(bundles);
        }

        private static void AddStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/font-awesome.min.css",
                      "~/css/flexslider.css",
                      "~/css/style.css"));
        }

        private static void AddScripts(BundleCollection bundles)
        {
            var scriptBundle = new ScriptBundle("~/bundles/scripts")
                .Include
                (
                    "~/js/jquery.min.js",
                    "~/js/skip-link-focus-fix.js",
                    "~/js/jquery.validate.min.js",
                    "~/js/flexslider.min.js",
                    "~/js/functions.min.js"
                );

            scriptBundle.Orderer = new NonOrderingBundleOrderer();
            bundles.Add(scriptBundle);
        }
    }

    class NonOrderingBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}