using SafetyAppliaction.Models;

namespace SafetyAppliaction.Services
{
    public interface IRequestService
    {
        Task<IEnumerable<Request>> GetAllRequestsAsync();
        Task<Request> GetRequestByIdAsync(int id);
        Task CreateRequestAsync(Request request, List<int> instructorIds, List<int> attendantIds);
        Task UpdateRequestAsync(Request request);
        Task DeleteRequestAsync(int id);
        Task<bool> RequestExistsAsync(int id);
        Task<IEnumerable<Status>> GetStatusesAsync();
        string GenerateFormNumber(string formName, string department, int sequenceNumber, DateTime date);
     
        Task<Request> GetRequestDetailAsync(int requestId);

       
    }

}
