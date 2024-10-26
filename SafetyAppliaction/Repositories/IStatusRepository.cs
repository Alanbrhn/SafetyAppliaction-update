using SafetyAppliaction.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetAllStatusesAsync();
    }
}
