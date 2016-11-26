using System.Web.Mvc;
using TravelBlog.Data;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers
{
    public class BlogPostController : RenderMvcController
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
