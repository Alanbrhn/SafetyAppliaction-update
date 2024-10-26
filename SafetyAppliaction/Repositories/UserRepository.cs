using Microsoft.EntityFrameworkCore;

using SafetyAppliaction.Models;
using SafetyApplication.Data;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SafetyAppliaction.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            var user = await _context.Users
                    .Include(u => u.Employee)          
                    .ThenInclude(e => e.Departements)    
                    .Include(u => u.Role)              
                    .FirstOrDefaultAsync(u => u.Email == username);

            return user;
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
