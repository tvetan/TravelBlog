using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Data;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class HomeController : RenderMvcController
    {
        private HomeService homeService;

        public HomeController()
        {
            this.homeService = new HomeService();
        }

        public ActionResult Home(RenderModel model)
        {
            var homeModel = homeService.GetModel(model.Content);

            return CurrentTemplate(homeModel);
        }
    }
}