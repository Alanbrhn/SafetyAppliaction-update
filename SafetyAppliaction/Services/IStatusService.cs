using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IStatusService
    {
        Task<IEnumerable<Status>> GetStatusesAsync();
    }
}
