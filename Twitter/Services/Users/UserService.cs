using Twitter.Models;
using Newtonsoft.Json;
namespace Twitter.Services.Users
{
    public class UserService : IUserInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/users";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient; 
        }
        public async Task<List<User>> GetUsersAsync()
        {
            var res = await _httpClient.GetAsync(BaseUrl);
            var response = await res.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<User>>(response.ToString());
            if(results != null){
                return results;
            }
            return new List<User>();
        }
    }
}