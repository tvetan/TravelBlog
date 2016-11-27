using System;
using System.Collections.Generic;

namespace TravelBlog.Models
{
    public class BlogPostModel : BaseModel
    {
        public BlogPostModel()
        {
            this.RelatedPosts = new List<BlogPostModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string MainImageUrl { get; set; }
        public string Url { get; set; }
        public DateTime CreateDate { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; }
        public string BlogPostContent { get; set; }
        public IEnumerable<BlogPostModel> RelatedPosts { get; set; }
        public BlogPostModel NextPost { get; set; }
        public BlogPostModel PreviousPost { get; set; }
        public bool ShowInSlider { get; set; }
        public string UrlWithDomain { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
