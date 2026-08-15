using backend.Enum;

namespace backend.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        public string Title { get; set; }
        public PostCategory PostCategory { get; set; }
        public string PostDescription { get; set; }
        
        public int noLikes { get; set; }

    }
}
