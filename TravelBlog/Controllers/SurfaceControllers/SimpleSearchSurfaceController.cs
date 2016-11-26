using System.Linq;
using System.Web.Mvc;
using TravelBlog.Data;
using TravelBlog.Models;
using TravelBlog.Utils.Consts;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace TravelBlog.Controllers.SurfaceControllers
{
    public class SimpleSearchSurfaceController : SurfaceController
    {
        public ActionResult Find(SimpleSearchModel model)
        {
            if (model.SearchedText == null)
            {
                return this.RedirectToUmbracoPage(model.HomePage.Descendant(DocumentTypesConsts.SearchResult));
            }

            var result = Umbraco.TypedSearch(model.SearchedText).ToList();

            var posts = result.Where(x => x.ContentType.Alias == DocumentTypesConsts.BlogPost)
                .Select(x => new BlogPostModel
                {
                    Id = x.Id,
                    Title = x.Name,
                    Url = x.Url,
                    CreateDate = x.CreateDate,
                    Summary = x.GetPropertyValue<string>(PostDocumentTypeConsts.Summary),
                    MainImageUrl = Methods.GetImage(x.GetPropertyValue<int>(PostDocumentTypeConsts.MainImage)),
                    Category = x.GetPropertyValue<string>(PostDocumentTypeConsts.Category)
                });


            this.TempData["SearchResult"] = posts;
            this.TempData["SearchedText"] = model.SearchedText;

            return this.RedirectToUmbracoPage(model.HomePage.Descendant(DocumentTypesConsts.SearchResult));
        }
    }
}
