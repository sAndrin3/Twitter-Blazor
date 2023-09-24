using Twitter.Models;
namespace Twitter.Services.Comments
{
    public interface ICommentInterface
    {
        Task<List<Comment>> GetCommentsAsync();
        Task<List<Comment>> GetCommentsByPostAsync(int id);

    }
}