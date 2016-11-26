using System.Collections.Generic;

namespace TravelBlog.Models
{
    public class HomeModel : BaseModel
    {
        public List<BlogPostModel> AllBlogPosts { get; set; }

        public List<BlogPostModel> SliderBlogPosts { get; set; }
    }
}
