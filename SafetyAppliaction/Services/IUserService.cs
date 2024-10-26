using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IUserService
    {
        Task<User> GetLoggedInUser();
    }
}
