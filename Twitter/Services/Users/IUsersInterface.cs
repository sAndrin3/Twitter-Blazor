using Twitter.Models;

namespace Twitter.Services.Users
{
    public interface IUserInterface
    {
        public Task<List<User>> GetUsersAsync();
    }
}