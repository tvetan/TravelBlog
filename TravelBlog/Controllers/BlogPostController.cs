using System.Web.Mvc;
using TravelBlog.Controllers.Base;
using TravelBlog.Data;

namespace TravelBlog.Controllers
{
    public class BlogPostController : BaseHttpsRenderMvcController
    {
        public BlogPostsService BlogPostsService { get; set; }

        public BlogPostController()
        {
            this.BlogPostsService = new BlogPostsService();
        }

        public ActionResult Index()
        {
            var model = this.BlogPostsService.GetModel(this.CurrentPage, Umbraco);
            return CurrentTemplate(model);
        }
    }
}
