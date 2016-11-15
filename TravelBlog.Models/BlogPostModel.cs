using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class BlogPostModel : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string MainImageUrl { get; set; }
        public string Url { get; set; }
        public DateTime CreateDate { get; set; }
        public string Summary { get; set; }
    }
}
