using System.Web.Mvc;
using TravelBlog.Data;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class HomeController : RenderMvcController
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
