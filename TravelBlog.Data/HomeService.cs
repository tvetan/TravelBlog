using System.Linq;
using TravelBlog.Models;
using TravelBlog.Utils.Consts;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace TravelBlog.Data
{
    public class HomeService
    {
        public HomeModel GetModel(IPublishedContent currentPage)
        {
            var model = new HomeModel();

            model.AllBlogPosts = currentPage
               .Descendants(DocumentTypesConsts.BlogPost)
               .Select(x => new BlogPostModel
               {
                   Id = x.Id,
                   Title = x.Name,
                   Url = x.Url,
                   CreateDate = x.CreateDate,
                   Summary = x.GetPropertyValue<string>(PostDocumentTypeConsts.Summary),
                   MainImageUrl = Methods.GetImage(x.GetPropertyValue<int>(PostDocumentTypeConsts.MainImage)),
                   Category = x.GetPropertyValue<string>(PostDocumentTypeConsts.Category),
                   ShowInSlider = x.GetPropertyValue<bool>(PostDocumentTypeConsts.ShowInSlider)
               })
               .OrderByDescending(x => x.CreateDate)
               .ToList();

            model.SliderBlogPosts = model.AllBlogPosts.Where(x => x.ShowInSlider).ToList();

            return model;
        }
    }
}
