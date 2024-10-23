using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IJwtTokenStorageService
    {
        Task SaveTokenInfoAsync(JwtTokenInfo tokenInfo);
    }
}
