using Twitter.Models;

namespace Twitter.Services.Posts
{
    public interface IPostInterface
    {
        Task<List<Post>> GetPostAsync();
    }
}