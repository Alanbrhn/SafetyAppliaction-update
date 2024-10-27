using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IWorklistService
    {
        Task AddWorklistAsync(Request request);
        Task<Worklist> GetWorklistByIdAsync(int id);
        Task<IEnumerable<Worklist>> GetAllWorklistsAsync();
        Task<List<Worklist>> GetPendingWorklistAsync(int employeeId);
        Task<int> GetPendingWorklistCountAsync(int employeeId);
        Task<Worklist> GetWorklistDetailsAsyn(int id);
        Task ApproveRequestAsync(int id, int employeeId);
        Task RejectRequestAsync(int id, int employeeId);
    }


}
