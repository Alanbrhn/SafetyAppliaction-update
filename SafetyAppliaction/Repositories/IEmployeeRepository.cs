using SafetyAppliaction.Models;
using SafetyApplication.Models;

namespace SafetyAppliaction.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeByEmailAsync(string Email);
    }
}
