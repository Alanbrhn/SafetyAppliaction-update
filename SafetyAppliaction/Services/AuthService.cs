using Microsoft.AspNetCore.Identity;
using SafetyAppliaction.Models;
using SafetyAppliaction.Repositories;
using SafetyApplication.Models;

namespace SafetyAppliaction.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthService(IUserRepository userRepository, IRoleRepository roleRepository, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<bool> RegisterAsync(string Email, string password, string roleName, int employeeId)
        {
            var existingUser = await _userRepository.GetUserByUsernameAsync(Email); 
            if (existingUser != null)
            {
                return false; 
            }

            var role = await _roleRepository.GetRoleByNameAsync(roleName);
            if (role == null)
            {
                return false;
            }

            var newUser = new User
            {
                Email = Email, 
                RoleId = role.RoleId,
                CreateDate = DateTime.UtcNow,
                CreateBy = "System",
                UpdateDate = DateTime.UtcNow,
                UpdateBy = "System",
                IsActive = true,
                EmployeeId = employeeId 
            };

            newUser.PasswordHash = _passwordHasher.HashPassword(newUser, password);

            await _userRepository.AddUserAsync(newUser);
            return true;
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            try
            {
                var user = await _userRepository.GetUserByUsernameAsync(username);

                if (user == null)
                {
                    
                    Console.WriteLine("User not found.");
                    return null;
                }

                if (string.IsNullOrEmpty(user.PasswordHash))
                {
                    
                    Console.WriteLine("PasswordHash is null or empty.");
                    return null;
                }
             var pass =   _passwordHasher.HashPassword(user, password);

                var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
                if (passwordVerificationResult != PasswordVerificationResult.Success)
                {
                    
                    Console.WriteLine("Password verification failed.");
                    return null;
                }

                return user; 
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine($"Format exception: {ex.Message}");
                throw; 
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred during login: {ex.Message}");
                throw; 
            }
        }

    }
}
