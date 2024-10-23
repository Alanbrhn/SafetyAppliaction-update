using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyApplication.Data;
using System;

namespace SafetyAppliaction.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleByNameAsync(string roleName)
        {
            return await _context.Roles.FirstOrDefaultAsync(r => r.RoleName == roleName);
        }
    }
}
