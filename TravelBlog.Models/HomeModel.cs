using System.Collections.Generic;

namespace TravelBlog.Models
{
    public class HomeModel : BaseModel
    {
        public List<BlogPostModel> AllBlogPosts { get; set; }
    }
}
