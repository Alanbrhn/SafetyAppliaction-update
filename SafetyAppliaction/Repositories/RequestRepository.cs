using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyApplication.Data;
using SafetyApplication.Models;

namespace SafetyAppliaction.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly AppDbContext _context;

        public RequestRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Request>> GetAllRequestsAsync()
        {
            return await _context.Requests.Include(r => r.Status).ToListAsync();
        }

        public async Task<Request> GetRequestByIdAsync(int id)
        {
            return await _context.Requests
                                 .Include(r => r.Status)
                                 .FirstOrDefaultAsync(r => r.RequestId == id);
        }

        public async Task CreateRequestAsync(Request request)
        {
            await _context.Requests.AddAsync(request);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRequestAsync(Request request)
        {
            _context.Requests.Update(request);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRequestAsync(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            if (request != null)
            {
                _context.Requests.Remove(request);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> RequestExistsAsync(int id)
        {
            return await _context.Requests.AnyAsync(r => r.RequestId == id);
        }

        public async Task<IEnumerable<Status>> GetStatusesAsync()
        {
            return await _context.Statuses.ToListAsync(); 
        }


        public async Task AddInstructorToRequestAsync(int requestId, int instructorId)
        {
            var request = await _context.Requests
                .Include(r => r.Instructors) // Include collection Instructors
                .FirstOrDefaultAsync(r => r.RequestId == requestId);

            if (request != null)
            {
               
                var instructor = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == instructorId);

                if (instructor != null)
                {
                    request.Instructors.Add(instructor); 
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task AddAttendantToRequestAsync(int requestId, int attendantId)
        {
            var request = await _context.Requests
                .Include(r => r.Attendants) 
                .FirstOrDefaultAsync(r => r.RequestId == requestId);

            if (request != null)
            {
                
                var attendant = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == attendantId);

                if (attendant != null)
                {
                    request.Attendants.Add(attendant); 
                    await _context.SaveChangesAsync();
                }
            }
        }
        public async Task<Request> GetRequestDetailAsync(int requestId)
        {
            // Menggunakan async/await untuk query
            var requestDetail = await _context.Requests
                .Include(r => r.Attendants)  // Mengambil data Attendants
                .Include(r => r.Instructors)  // Mengambil data Instructors
                .Where(r => r.RequestId == requestId)  // Menyaring berdasarkan requestId
                .Select(r => new Request
                {
                    RequestId = r.RequestId,
                    Title = r.Title,
                    PotentialDangerousPoint = r.PotentialDangerousPoint,
                    TheMostDangerPoint = r.TheMostDangerPoint,
                    KeyWord = r.KeyWord,
                    FormNo = r.FormNo,
                    Departement = r.Departement,
                    Section = r.Section,
                    Date = r.Date,
                    Time = r.Time,
                    Company = r.Company,
                    StatusId = r.StatusId,
                    ApprovalStage = r.ApprovalStage,
                    CreateDate = r.CreateDate,
                    CreateBy = r.CreateBy,
                    UpdateDate = r.UpdateDate,
                    UpdateBy = r.UpdateBy,
                    Instructors = r.Instructors.Select(i => new Employee
                    {
                        EmployeeId = i.EmployeeId, // Ganti dengan ID karyawan yang sesuai
                        EmployeeName = i.EmployeeName // Pastikan Anda memiliki properti Name dalam model Employee
                    }).ToList(),
                    Attendants = r.Attendants.Select(a => new Employee
                    {
                        EmployeeId = a.EmployeeId, // Ganti dengan ID karyawan yang sesuai
                        EmployeeName = a.EmployeeName // Pastikan Anda memiliki properti Name dalam model Employee
                    }).ToList()
                })
                .FirstOrDefaultAsync(); // Menggunakan FirstOrDefaultAsync untuk mengambil hasil

            // Periksa apakah requestDetail null
            if (requestDetail == null)
            {
                return null; // Atau lemparkan exception, atau kembalikan nilai default
            }

            // Kembalikan requestDetail yang telah diperiksa
            return requestDetail;
        }


    }

}
