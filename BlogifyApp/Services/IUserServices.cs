using BlogifyAPI.Models;

namespace BlogifyApp.Services
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
