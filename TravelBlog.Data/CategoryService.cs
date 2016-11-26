using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Models;
using Umbraco.Core.Models;

namespace TravelBlog.Data
{
    public class CategoryService
    {
        public BlogPostsService BlogPostsService { get; set; }

        public CategoryService()
        {
            this.BlogPostsService = new BlogPostsService();
        }

        public CategoryModel GetModel(IPublishedContent currentPage)
        {
            var model = new CategoryModel();
            model.AllBlogPosts = this.BlogPostsService.GetModelsByCategory(currentPage);

            return model;
        }
    }
}
