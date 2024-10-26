using SafetyApplication.Models;

namespace SafetyAppliaction.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();
        Task<int> GetApproverByStage(object departmentId, int v);
        Task<Employee> GetEmployeeByEmail(string email);
    }
}
