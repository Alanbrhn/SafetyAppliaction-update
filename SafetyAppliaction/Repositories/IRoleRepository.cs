using SafetyAppliaction.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleByNameAsync(string roleName);
    }
}
