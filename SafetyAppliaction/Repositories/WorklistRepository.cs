using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyApplication.Data;

namespace SafetyAppliaction.Repositories
{
    public class WorklistRepository : IWorklistRepository
    {
        private readonly AppDbContext _context;

        public WorklistRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddWorklistAsync(Worklist worklist)
        {
            await _context.Worklists.AddAsync(worklist);
            await _context.SaveChangesAsync();
        }

        public async Task<Worklist> GetWorklistByIdAsync(int id)
        {
            return await _context.Worklists
                .Include(w => w.Request)
                .Include(w => w.Status) 
                .FirstOrDefaultAsync(w => w.WorklistId == id);
        }

        public async Task<IEnumerable<Worklist>> GetAllWorklistsAsync()
        {
            return await _context.Worklists
                .Include(w => w.Request) 
                .Include(w => w.Status) 
                .ToListAsync();
        }

        public async Task<List<Worklist>> GetPendingWorklistByEmployeeIdAsync(int employeeId)
        {
            return await _context.Worklists
                .Join(
                    _context.Requests, 
                    worklist => worklist.RequestId, 
                    request => request.RequestId, 
                    (worklist, request) => new { Worklist = worklist, Request = request } 
                )
                .Where(x => x.Request.NextApprover == employeeId) 
                .Select(x => x.Worklist) 
                .ToListAsync();
        }


        public async Task<int> GetPendingWorklistCountByEmployeeIdAsync(int employeeId)
        {
            return await _context.Worklists
                .Join(
                    _context.Requests,
                    worklist => worklist.RequestId,
                    request => request.RequestId,
                    (worklist, request) => new { Worklist = worklist, Request = request }
                )
                .CountAsync(x => x.Request.NextApprover == employeeId);
        }

        public async Task<Worklist> GetWorklistDetails(int id)
        {
            return await _context.Worklists.FindAsync(id);
        }

        public async Task ApproveRequest(int id, int employeeId)
        {
            var worklist = await _context.Worklists
                .FirstOrDefaultAsync(w => w.RequestId == id);

            if (worklist == null)
            {
                throw new ArgumentException("Worklist not found.");
            }

            var request = await _context.Requests
                .FirstOrDefaultAsync(r => r.RequestId == id);

            if (request == null)
            {
                throw new ArgumentException("Request not found.");
            }

            var department = await _context.Departements
                .FirstOrDefaultAsync(d => d.DepartmentName == request.Departement);

            if (department == null)
            {
                throw new ArgumentException("Invalid Department");
            }

            var employeeName = await _context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => e.EmployeeName)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(employeeName))
            {
                throw new ArgumentException("Invalid Employee ID");
            }

            worklist.UpdateBy = employeeName;
            worklist.UpdateDate = DateTime.Now;

            string approver = string.Empty;
            int EmployeeIdApprover = 0;

         
            switch (worklist.ApprovalStage)
            {
                case 1:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.AdminId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();
                    EmployeeIdApprover = department.SecretaryId;
                    worklist.StatusId = 2;  
                    worklist.ApprovalStage = 2;
                    break;

                case 2:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.SecretaryId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();
                    EmployeeIdApprover = department.DeptHeadId;
                    worklist.StatusId = 3;  
                    worklist.ApprovalStage = 3;
                    break;

                case 3:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.DeptHeadId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();
                    EmployeeIdApprover = department.ManagerId;
                    worklist.StatusId = 4;  
                    worklist.ApprovalStage = 4;
                    break;

                case 4:
                    approver = await _context.Employees
                        .Where(e => e.EmployeeId == department.ManagerId)
                        .Select(e => e.EmployeeName)
                        .FirstOrDefaultAsync();
                    EmployeeIdApprover = 0;  
                    worklist.StatusId = 5;  
                    worklist.ApprovalStage = 5;  
                    break;

                default:
                    throw new ArgumentException("Invalid Approval Stage");
            }

            if (string.IsNullOrEmpty(approver))
            {
                throw new Exception("No approver found for the given Approval Stage");
            }

        
            worklist.Approver = approver;
            worklist.EmployeeId = EmployeeIdApprover;

         
            request.UpdateDate = DateTime.Now;
            request.UpdateBy = employeeName;
            request.StatusId = worklist.StatusId;
            request.ApprovalStage = worklist.ApprovalStage;

          
            if (worklist.ApprovalStage == 4 && worklist.StatusId == 5)
            {
              
                request.NextApprover = 0;  
            }
            else
            {
                
                request.NextApprover = EmployeeIdApprover;
            }

            await _context.SaveChangesAsync();
        }





        public async Task RejectRequest(int id, int employeeId)
        {
            var worklist = await _context.Worklists
            .FirstOrDefaultAsync(w => w.RequestId == id);

            var employeeName = _context.Employees
            .Where(e => e.EmployeeId == employeeId)
            .Select(e => e.EmployeeName)
            .FirstOrDefault();

            if (worklist != null)
            {
                worklist.StatusId = 3; 
                worklist.UpdateBy = employeeName; 
                worklist.UpdateDate = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }

        
    }

}
