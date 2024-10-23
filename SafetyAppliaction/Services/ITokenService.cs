using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
