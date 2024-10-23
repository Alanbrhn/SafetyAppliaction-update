using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(string username, string password, string roleName, int employeeId);
        Task<User> LoginAsync(string username, string password);
    }
}
