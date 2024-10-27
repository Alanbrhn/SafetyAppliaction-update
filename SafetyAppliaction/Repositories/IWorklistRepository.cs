using SafetyAppliaction.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IWorklistRepository
    {
        Task AddWorklistAsync(Worklist worklist);
        Task<Worklist> GetWorklistByIdAsync(int id);
        Task<IEnumerable<Worklist>> GetAllWorklistsAsync();
        Task<List<Worklist>> GetPendingWorklistByEmployeeIdAsync(int employeeId);
        Task<int> GetPendingWorklistCountByEmployeeIdAsync(int employeeId);
        Task<Worklist> GetWorklistDetails(int id);
        Task ApproveRequest(int id, int employeeId);
        Task RejectRequest(int id, int employeeId);
    }

}
