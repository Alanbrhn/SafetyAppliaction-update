using SafetyAppliaction.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IWorklistRepository
    {
        Task AddWorklistAsync(Worklist worklist);
        Task<Worklist> GetWorklistByIdAsync(int id);
        Task<IEnumerable<Worklist>> GetAllWorklistsAsync();
    }

}
