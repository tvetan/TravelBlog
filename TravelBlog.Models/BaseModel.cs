using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace TravelBlog.Models
{
    public class BaseModel : RenderModel
    {
        public IPublishedContent HomePage { get; set; }

        public BaseModel()
            : this(new UmbracoHelper(UmbracoContext.Current).TypedContent(UmbracoContext.Current.PageId))
        {
            this.HomePage = this.Content.AncestorOrSelf(1);
        }

        public BaseModel(IPublishedContent content, CultureInfo culture)
            : base(content, culture)
        {
            this.HomePage = content.AncestorOrSelf(1);
        }

        public BaseModel(IPublishedContent content)
            : base(content)
        {
            this.HomePage = content.AncestorOrSelf(1);
        }
    }
}
