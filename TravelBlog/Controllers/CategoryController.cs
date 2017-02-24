using System.Web.Mvc;
using TravelBlog.Controllers.Base;
using TravelBlog.Data;

namespace TravelBlog.Controllers
{
    public class CategoryController : BaseHttpsRenderMvcController
    {
        public CategoryService CategoryService { get; set; }

        public CategoryController()
        {
            this.CategoryService = new CategoryService();
        }

        public ActionResult Index()
        {
            var model = this.CategoryService.GetModel(this.CurrentPage);
            return CurrentTemplate(model);
        }
    }
}
