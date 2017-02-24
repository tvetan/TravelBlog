using System.Web.Mvc;
using TravelBlog.Controllers.Base;
using TravelBlog.Data;
using Umbraco.Web.Models;

namespace TravelBlog.Controllers
{
    public class TextController : BaseHttpsRenderMvcController
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
