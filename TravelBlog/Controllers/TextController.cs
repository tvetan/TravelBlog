using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Data;
using TravelBlog.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class TextController : RenderMvcController
    {
        public TextService TextService { get; set; }

        public TextController()
        {
            this.TextService = new TextService();
        }

        public ActionResult Text(RenderModel model)
        {
            TextModel textModel = this.TextService.GetModel(model.Content);
            return CurrentTemplate(textModel);
        }
    }
}