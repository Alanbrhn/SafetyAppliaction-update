using SafetyApplication.Models;

namespace SafetyAppliaction.Services
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeByEmail(string email);
    }
}
