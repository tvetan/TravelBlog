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
                    Category = x.GetPropertyValue<string>(PostDocumentTypeConsts.Category),
                    ModifiedDate = currentPage.UpdateDate,
                    UrlWithDomain= currentPage.UrlWithDomain()
                })
                .OrderByDescending(x => x.CreateDate)
                .ToList();
        }

        public BlogPostModel GetModel(IPublishedContent currentPage, UmbracoHelper umbraco)
        {
            var blogPostModel = GetModel(currentPage);

            if (currentPage.HasValue("nextpost"))
            {
                var node = umbraco.TypedContent(currentPage.GetPropertyValue<int>("nextpost"));
                blogPostModel.NextPost = GetModel(node);
            }

            if (currentPage.HasValue("previouspost"))
            {
                var node = umbraco.TypedContent(currentPage.GetPropertyValue<int>("previouspost"));
                blogPostModel.PreviousPost = GetModel(node);
            }

            blogPostModel.RelatedPosts = this.GetModelsByCategory(currentPage.Parent).
                Where(x => x.Id != currentPage.Id).Take(3);

            return blogPostModel;
        }

        private static BlogPostModel GetModel(IPublishedContent currentPage)
        {
            return new BlogPostModel
            {
                Id = currentPage.Id,
                Title = currentPage.Name,
                Url = currentPage.Url,
                CreateDate = currentPage.CreateDate,
                Summary = currentPage.GetPropertyValue<string>(PostDocumentTypeConsts.Summary),
                MainImageUrl = Methods.GetImage(currentPage.GetPropertyValue<int>(PostDocumentTypeConsts.MainImage)),
                Category = currentPage.GetPropertyValue<string>(PostDocumentTypeConsts.Category),
                BlogPostContent = currentPage.GetPropertyValue<string>(PostDocumentTypeConsts.Content),
                UrlWithDomain = currentPage.UrlWithDomain(),
                ModifiedDate = currentPage.UpdateDate
            };
        }
    }
}
