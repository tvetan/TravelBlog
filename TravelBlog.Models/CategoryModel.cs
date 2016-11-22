using System.Collections.Generic;

namespace TravelBlog.Models
{
    public class CategoryModel : BaseModel
    {
        public IEnumerable<BlogPostModel> AllBlogPosts { get; set; }
    }
}
