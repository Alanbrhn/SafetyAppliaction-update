using Microsoft.EntityFrameworkCore;
using SafetyApplication.Data;
using SafetyApplication.Models;

namespace SafetyAppliaction.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }



        public async Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            try
            {
                var employee = await _context.Employees
                    .FirstOrDefaultAsync(e => e.Email.ToLower() == email.ToLower());

                return employee; 
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred while fetching the employee: {ex.Message}");
                return null; 
            }
        }

        
    }

}
