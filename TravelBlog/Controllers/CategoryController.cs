using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Data;
using TravelBlog.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class CategoryController : RenderMvcController
    {
        public CategoryService CategoryService { get; set; }

        public CategoryController()
        {
            this.CategoryService = new CategoryService();
        }

        public ActionResult Index()
        {
            CategoryModel model = this.CategoryService.GetModel(this.CurrentPage);
            return CurrentTemplate(model);
        }
    }
}