namespace Twitter.Models
{
    public class Comment
    {
        public int id {get; set;}
        public string name {get; set;}
        public string email {get; set;}
        public string body {get; set;}
        public int postId {get; set;}
    }
}