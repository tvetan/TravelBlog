using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
               })
               .OrderByDescending(x => x.CreateDate)
               .ToList();

            return model;
        }
    }
}
