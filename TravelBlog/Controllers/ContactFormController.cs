using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Data;
using TravelBlog.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class ContactFormController : SurfaceController
    {
        private ContactRequestService contactRequestService;

        public ContactFormController()
        {
            this.contactRequestService = new ContactRequestService(Services.ContentService);
        }

        [HttpPost]
        public ActionResult Submit(ContactRequestModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            contactRequestService.CreateContactRequest(model);

            return RedirectToCurrentUmbracoPage();
        }
    }
}