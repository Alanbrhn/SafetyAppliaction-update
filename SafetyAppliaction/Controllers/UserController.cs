using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SafetyAppliaction.Repositories;

namespace SafetyAppliaction.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Authorize(Policy = "UserPolicy")]
        public IActionResult Index()
        {
            //var users = _userRepository.GetAllUsers();
            //return View(users); // Mengembalikan view Index untuk data user
            return View();
        }
    }

}
