using SafetyAppliaction.Repositories;
using SafetyAppliaction.Services;
using SafetyApplication.Models;


namespace SafetyApplication.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository; 

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            
            var employee = await _employeeRepository.GetEmployeeByEmailAsync(email);
            if (employee == null)
            {
               
                return null; 
            }

            return employee; 
        }
    }
}
