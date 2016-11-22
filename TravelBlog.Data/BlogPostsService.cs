using System.Collections.Generic;
using System.Linq;
using TravelBlog.Models;
using TravelBlog.Utils.Consts;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace TravelBlog.Data
{
    public class BlogPostsService
    {
        public IEnumerable<BlogPostModel> GetModelsByCategory(IPublishedContent currentPage)
        {
            return currentPage
                .Children
                .Select(x => new BlogPostModel
                {
                    Id = x.Id,
                    Title = x.Name,
                    Url = x.Url,
                    CreateDate = x.CreateDate,
                    Summary = x.GetPropertyValue<string>(PostDocumentTypeConsts.Summary),
                    MainImageUrl = Methods.GetImage(x.GetPropertyValue<int>(PostDocumentTypeConsts.MainImage)),
                    Category = x.GetPropertyValue<string>(PostDocumentTypeConsts.Category)
                }).OrderByDescending(x => x.CreateDate).ToList();
        }

        public BlogPostModel GetModel(IPublishedContent currentPage)
        {
            var blogPostModel = new BlogPostModel
            {
                Id = currentPage.Id,
                Title = currentPage.Name,
                Url = currentPage.Url,
                CreateDate = currentPage.CreateDate,
                Summary = currentPage.GetPropertyValue<string>(PostDocumentTypeConsts.Summary),
                MainImageUrl = Methods.GetImage(currentPage.GetPropertyValue<int>(PostDocumentTypeConsts.MainImage)),
                Category = currentPage.GetPropertyValue<string>(PostDocumentTypeConsts.Category),
                BlogPostContent = currentPage.GetPropertyValue<string>(PostDocumentTypeConsts.Content)
            };

            return blogPostModel;
        }
    }
}
