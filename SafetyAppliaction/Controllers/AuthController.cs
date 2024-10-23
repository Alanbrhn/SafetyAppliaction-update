using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SafetyAppliaction.Models;
using SafetyAppliaction.Services;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SafetyAppliaction.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEmployeeService _employeeService; 
        private readonly ITokenService _tokenService;
        private readonly IJwtTokenStorageService _jwtTokenStorageService;
        private readonly JwtSettings _jwtSettings;

        public AuthController(IAuthService authService, IEmployeeService employeeService, ITokenService tokenService, IJwtTokenStorageService jwtTokenStorage, JwtSettings jwtSettings)
        {
            _authService = authService;
            _employeeService = employeeService;
            _tokenService = tokenService;
            _jwtTokenStorageService = jwtTokenStorage;
            _jwtSettings = jwtSettings;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _authService.LoginAsync(username, password);

            if (user != null)
            {
                
                var token = _tokenService.GenerateToken(user);

                var tokenInfo = new JwtTokenInfo
                {
                    SecretKey = _jwtSettings.SecretKey,
                    Issuer = _jwtSettings.Issuer,
                    Audience = _jwtSettings.Audience,
                    ExpiryInMinutes = _jwtSettings.ExpiryInMinutes
                };

                await _jwtTokenStorageService.SaveTokenInfoAsync(tokenInfo);

                // Menyimpan token di cookie
                HttpContext.Response.Cookies.Append("AuthToken", token, new CookieOptions
                {
                    HttpOnly = true, 
                    Expires = DateTime.Now.AddMinutes(30), 
                });

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string username, string password)
        {
           
            var employee = await _employeeService.GetEmployeeByEmail(username);
            if (employee == null)
            {
                ModelState.AddModelError(string.Empty, "Employee tidak ditemukan.");
                return View(); 
            }

            
            var result = await _authService.RegisterAsync(username, password,"User", employee.EmployeeId);
            if (result)
            {
                return RedirectToAction("Login"); 
            }

            ModelState.AddModelError(string.Empty, "User sudah ada atau terjadi kesalahan saat pendaftaran.");
            return View(); 
        }

     
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            var token = HttpContext.Request.Cookies["AuthToken"]; 
            if (!string.IsNullOrEmpty(token))
            {

                
                HttpContext.Response.Cookies.Delete("AuthToken");
            }
            await HttpContext.SignOutAsync("Cookies");

            return RedirectToAction("Login", "Auth"); 
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
