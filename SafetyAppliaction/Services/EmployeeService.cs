using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
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

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employee = await _employeeRepository.GetAll();
            if (employee == null)
            {

                return null;
            }

            return employee;
        }

        public object GetApproverByStage(object departmentId, int v)
        {
            throw new NotImplementedException();
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

        Task<int> IEmployeeService.GetApproverByStage(object departmentId, int v)
        {
            throw new NotImplementedException();
        }
    }
}
