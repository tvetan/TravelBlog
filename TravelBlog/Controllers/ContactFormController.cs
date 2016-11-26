using System.Web.Mvc;
using TravelBlog.Data;
using TravelBlog.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class ContactFormController : SurfaceController
    {
        private readonly ContactRequestService contactRequestService;

        public ContactFormController()
        {
            this.contactRequestService = new ContactRequestService(Services.ContentService);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(ContactRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["Error"] = "Not all field are valid";
                return CurrentUmbracoPage();
            }

            this.contactRequestService.CreateContactRequest(model);

            this.TempData["Success"] = "Contact form submitted successfully";
            return RedirectToCurrentUmbracoPage();
        }
    }
}
