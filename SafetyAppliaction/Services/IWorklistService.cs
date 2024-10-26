using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IWorklistService
    {
        Task AddWorklistAsync(Request request);
        Task<Worklist> GetWorklistByIdAsync(int id);
        Task<IEnumerable<Worklist>> GetAllWorklistsAsync();
    }

}
