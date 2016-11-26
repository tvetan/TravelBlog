namespace TravelBlog.Models
{
    public class TextModel : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public new string Content { get; set; }
    }
}
