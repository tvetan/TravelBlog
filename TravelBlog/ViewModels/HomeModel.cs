using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TravelBlog.ViewModels
{
    public class HomeModel : RenderModel
    {
        public HomeModel(IPublishedContent content) : base(content)
        { }

        public string MainTitle { get; set; }

        public string MainSubTitle { get; set; }
    }
}