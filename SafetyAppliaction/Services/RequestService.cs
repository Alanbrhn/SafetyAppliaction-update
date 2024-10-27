using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyAppliaction.Repositories;

namespace SafetyAppliaction.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<IEnumerable<Request>> GetAllRequestsAsync()
        {
            return await _requestRepository.GetAllRequestsAsync();
        }

        public async Task<Request> GetRequestByIdAsync(int id)
        {
            return await _requestRepository.GetRequestByIdAsync(id);
        }

        public async Task CreateRequestAsync(Request request)
        {
            await _requestRepository.CreateRequestAsync(request);
        }

        public async Task UpdateRequestAsync(Request request)
        {
            await _requestRepository.UpdateRequestAsync(request);
        }

        public async Task DeleteRequestAsync(int id)
        {
            await _requestRepository.DeleteRequestAsync(id);
        }

        public async Task<bool> RequestExistsAsync(int id)
        {
            return await _requestRepository.RequestExistsAsync(id);
        }
        public async Task<IEnumerable<Status>> GetStatusesAsync()
        {
            return await _requestRepository.GetStatusesAsync();
        }

        public string GenerateFormNumber(string formName, string department, int sequenceNumber, DateTime date)
        {
            string formCode = formName.Length >= 3 ? formName.Substring(0, 3).ToUpper() : formName.ToUpper();
            string departmentCode = department.Length >= 2 ? department.Substring(0, 2).ToUpper() : department.ToUpper();

            string sequence = sequenceNumber.ToString("D2");

            string month = date.ToString("MMM", System.Globalization.CultureInfo.InvariantCulture);

            string day = date.Day.ToString("D2");

            string year = date.ToString("yy");

            string formNumber = $"{formCode}-{departmentCode}-{sequence}, {day}-{month}-{year}";

            return  formNumber;
        }

        public async Task CreateRequestAsync(Request request, List<int> instructorIds, List<int> attendantIds)
        {
             await _requestRepository.CreateRequestAsync(request);

            foreach (var instructorId in instructorIds)
            {
                await _requestRepository.AddInstructorToRequestAsync(request.RequestId, instructorId);
            }

            foreach (var attendantId in attendantIds)
            {
                await _requestRepository.AddAttendantToRequestAsync(request.RequestId, attendantId);
            }
           
        }

        public async Task<Request> GetRequestDetailAsync(int requestId)
        {
            return await _requestRepository.GetRequestDetailAsync(requestId);
        }

        
    }

}
