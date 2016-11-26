using System;
using TravelBlog.Models;
using Umbraco.Core.Services;

namespace TravelBlog.Data
{
    public class ContactRequestService
    {
        private readonly IContentService contentService;

        public ContactRequestService(IContentService contentService)
        {
            this.contentService = contentService;
        }

        public void CreateContactRequest(ContactRequestModel model)
        {
            var content = contentService.CreateContent(model.Subject + " " + DateTime.UtcNow.ToString("dd-MM-yyy"), 1108, "contactRequest", 0);

            content.SetValue("UserFirstName", model.Name);
            content.SetValue("email", model.Email);
            content.SetValue("message", model.Message);
            content.SetValue("subject", model.Subject);

            contentService.SaveAndPublishWithStatus(content);
        }
    }
}
