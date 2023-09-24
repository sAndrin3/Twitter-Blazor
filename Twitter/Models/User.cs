namespace Twitter.Models
{
    public class User
    {
        public int id {get; set;}
        public string username {get; set;}
        public string email {get; set;}
        public string name {get; set;}
        public object? address {get; set;}
    }
}