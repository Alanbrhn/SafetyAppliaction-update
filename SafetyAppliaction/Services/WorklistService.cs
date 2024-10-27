using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyAppliaction.Repositories;
using SafetyApplication.Data;

namespace SafetyAppliaction.Services
{
    public class WorklistService : IWorklistService
    {
        private readonly IWorklistRepository _worklistRepository;
        private readonly AppDbContext _context;

        public WorklistService(IWorklistRepository worklistRepository, AppDbContext context)
        {
            _worklistRepository = worklistRepository;
            _context = context;
        }

        public async Task AddWorklistAsync(Request request)
        {
            // Ambil employee berdasarkan nama departemen langsung dalam satu query
            var employee = await _context.Employees
                .Include(e => e.Departements)
                .Where(e => e.Departements.DepartmentName == request.Departement)
                .FirstOrDefaultAsync();


            if (employee == null)
            {
                throw new ArgumentException("Invalid Employee ID");
            }

            var department = employee.Departements;
            string approver = string.Empty;
            int EmployeeIdApprover = 0;

            // Determine approver based on ApprovalStage
            switch (request.ApprovalStage)
            {
                case 1:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.AdminId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();

                    EmployeeIdApprover = department.AdminId;

                    break;
                case 2:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.SecretaryId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();

                    EmployeeIdApprover = department.SecretaryId;
                    break;
                case 3:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.DeptHeadId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();

                    EmployeeIdApprover = department.DepartmentId;
                    break;
                case 4:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.ManagerId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();

                    EmployeeIdApprover = department.ManagerId;
                    break;
                default:
                    throw new ArgumentException("Invalid Approval Stage");
            }

            if (string.IsNullOrEmpty(approver))
            {
                throw new Exception("No approver found for the given Approval Stage");
            }

            // Insert into Worklist
            var worklist = new Worklist
            {
                RequestId = request.RequestId,
                Approver = approver,
                StatusId = request.StatusId,
                CreateDate = DateTime.Now,
                CreateBy = employee.EmployeeName,
                ApprovalStage = request.ApprovalStage,
                EmployeeId = EmployeeIdApprover
            };

            _context.Worklists.Add(worklist);
            await _context.SaveChangesAsync();
        }



        public async Task<Worklist> GetWorklistByIdAsync(int id)
        {
            return await _worklistRepository.GetWorklistByIdAsync(id);
        }

        public async Task<IEnumerable<Worklist>> GetAllWorklistsAsync()
        {
            return await _worklistRepository.GetAllWorklistsAsync();
        }

        public async Task<List<Worklist>> GetPendingWorklistAsync(int employeeId)
        {
            return await _worklistRepository.GetPendingWorklistByEmployeeIdAsync(employeeId);
        }

        public async Task<int> GetPendingWorklistCountAsync(int employeeId)
        {
            return await _worklistRepository.GetPendingWorklistCountByEmployeeIdAsync(employeeId);
        }

        public async Task<Worklist> GetWorklistDetailsAsyn(int id)
        {
            return await _worklistRepository.GetWorklistDetails(id);
        }

        public async Task ApproveRequestAsync(int id, int employeeId)
        {
            await _worklistRepository.ApproveRequest(id, employeeId);
        }

        public async Task RejectRequestAsync(int id, int employeeId)
        {
            await _worklistRepository.RejectRequest(id, employeeId);
        }

       
    }

}
