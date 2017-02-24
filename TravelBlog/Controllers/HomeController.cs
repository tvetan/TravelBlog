using System.Web.Mvc;
using TravelBlog.Controllers.Base;
using TravelBlog.Data;
using Umbraco.Web.Models;

namespace TravelBlog.Controllers
{
    public class HomeController : BaseHttpsRenderMvcController
    {
        private readonly HomeService homeService;

        public HomeController()
        {
            this.homeService = new HomeService();
        }

        public ActionResult Home(RenderModel model)
        {
            var homeModel = this.homeService.GetModel(model.Content);

            return this.CurrentTemplate(homeModel);
        }
    }
}
