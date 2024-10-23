using SafetyAppliaction.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
    }
}
