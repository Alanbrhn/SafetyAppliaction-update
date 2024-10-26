using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyApplication.Data;

namespace SafetyAppliaction.Services
{
    public class JwtTokenStorageService: IJwtTokenStorageService
    {
        private readonly AppDbContext _context;

        public JwtTokenStorageService(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveTokenInfoAsync(JwtTokenInfo tokenInfo)
        {
            tokenInfo.CreatedAt = DateTime.Now;
            _context.JwtTokens.Add(tokenInfo);
            await _context.SaveChangesAsync();
        }
    }

    
}
