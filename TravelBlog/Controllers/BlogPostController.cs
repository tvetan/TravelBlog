using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Data;
using TravelBlog.Models;
using Umbraco.Core.Models;
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
            var model = this.BlogPostsService.GetModel(this.CurrentPage);
            return CurrentTemplate(model);
        }
    }
}