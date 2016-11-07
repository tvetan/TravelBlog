using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.ViewModels;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class HomeController : RenderMvcController
    {
        public ActionResult Home(RenderModel model)
        {
            var blogOverviewModel = new HomeModel(model.Content);
            //blogOverviewModel.MainTitle = "some title";
            blogOverviewModel.MainSubTitle = "sub title";

            return CurrentTemplate(blogOverviewModel);
        }
    }
}