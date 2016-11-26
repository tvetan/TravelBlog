using System.Web.Mvc;
using TravelBlog.Data;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class TextController : RenderMvcController
    {
        public readonly TextService textService;

        public TextController()
        {
            this.textService = new TextService();
        }

        public ActionResult Text(RenderModel model)
        {
            var textModel = this.textService.GetModel(model.Content);
            return CurrentTemplate(textModel);
        }
    }
}
