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
                .Include(w => w.Request) // Include related Request
                .Include(w => w.Status) // Include related Status
                .FirstOrDefaultAsync(w => w.WorklistId == id);
        }

        public async Task<IEnumerable<Worklist>> GetAllWorklistsAsync()
        {
            return await _context.Worklists
                .Include(w => w.Request) 
                .Include(w => w.Status) 
                .ToListAsync();
        }
    }

}
