using SafetyAppliaction.Models;
using SafetyAppliaction.Repositories;

namespace SafetyAppliaction.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IUserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<User> GetLoggedInUser()
        {
            var username = _httpContextAccessor.HttpContext.User.Identity.Name;
            return await _userRepository.GetUserByUsernameAsync(username);
        }

        
    }

}
