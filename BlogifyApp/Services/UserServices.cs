using BlogifyAPI.Models;

namespace BlogifyApp.Services
{
    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;
        public UserServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return (IEnumerable<User>)await _httpClient.GetFromJsonAsync<User>("api/user/getUsers");
        }
    }
}
