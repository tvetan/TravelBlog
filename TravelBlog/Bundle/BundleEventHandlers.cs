using System.Web.Optimization;
using Umbraco.Core;

namespace TravelBlog.Bundle
{
    public class BundleEventHandlers : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}