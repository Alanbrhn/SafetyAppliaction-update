using SafetyAppliaction.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IRequestRepository
    {
        Task<IEnumerable<Request>> GetAllRequestsAsync();
        Task<Request> GetRequestByIdAsync(int id);
        Task CreateRequestAsync(Request request);
        Task UpdateRequestAsync(Request request);
        Task DeleteRequestAsync(int id);
        Task<bool> RequestExistsAsync(int id);
        Task<IEnumerable<Status>> GetStatusesAsync();
        Task AddInstructorToRequestAsync(int requestId, int instructorId);
        Task AddAttendantToRequestAsync(int requestId, int attendantId);

    }

}
