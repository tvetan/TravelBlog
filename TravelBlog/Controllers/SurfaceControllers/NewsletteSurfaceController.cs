using System;
using System.Linq;
using System.Web.Mvc;
using TravelBlog.Models;
using TravelBlog.Utils.Consts;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers.SurfaceControllers
{
    public class NewsletteSurfaceController : SurfaceController
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Subscribe(NewsletterModel model)
        {
            if (ModelState.IsValid)
            {
                // Get newsletter page
                var bulletinDocType = CurrentPage
                    .AncestorOrSelf(1)
                    .Descendant(DocumentTypesConsts.Newsletter);

                // Get emails property
                var propertyValue = bulletinDocType.GetPropertyValue<string>(NewsletterTypeConsts.Subscribers);

                // Check if provided email already exist
                var values = propertyValue.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (values.Contains(model.Email))
                {
                    this.TempData["Error"] = bulletinDocType.GetPropertyValue<string>(NewsletterTypeConsts.TheEmailAlreadyExistsErrorMessage);
                    return RedirectToCurrentUmbracoPage();
                }

                if (bulletinDocType != null)
                {
                    // Get content service
                    var contentService = Services.ContentService;
                    var content = contentService.GetById(bulletinDocType.Id);

                    var newPropertyValue = propertyValue + "," + model.Email;

                    // Set new property value
                    content.SetValue(NewsletterTypeConsts.Subscribers, newPropertyValue);

                    contentService.SaveAndPublishWithStatus(content);

                    this.TempData["Success"] = bulletinDocType.GetPropertyValue<string>(NewsletterTypeConsts.SuccessfullSubscriptionMessage);
                    return this.RedirectToCurrentUmbracoPage();
                }
            }

            this.TempData["Error"] = model.HomePage.GetPropertyValue<string>(HomeDocumentTypeConsts.GlobalErrorMessage);
            return RedirectToCurrentUmbracoPage();
        }
    }
}
