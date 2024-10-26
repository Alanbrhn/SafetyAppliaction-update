using SafetyAppliaction.Models;
using SafetyAppliaction.Repositories;

namespace SafetyAppliaction.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public async Task<IEnumerable<Status>> GetStatusesAsync()
        {
            return await _statusRepository.GetAllStatusesAsync();
        }
    }
}
