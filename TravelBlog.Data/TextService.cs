using TravelBlog.Models;
using TravelBlog.Utils.Consts;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace TravelBlog.Data
{
    public class TextService
    {
        public TextModel GetModel(IPublishedContent currentPage)
        {
            var model = new TextModel();

            model.Id = currentPage.Id;
            model.Title = currentPage.Name;
            model.Content = currentPage.GetPropertyValue<string>(TextDocumentTypeConsts.Content);

            return model;
        }
    }
}
