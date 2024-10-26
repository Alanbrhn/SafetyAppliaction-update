using SafetyAppliaction.Models;
using SafetyApplication.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();
        Task<Employee> GetEmployeeByEmailAsync(string Email);
    }
}
