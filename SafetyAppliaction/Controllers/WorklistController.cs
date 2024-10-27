using Microsoft.AspNetCore.Mvc;
using SafetyAppliaction.Models;
using SafetyAppliaction.Services;
using System.Threading.Tasks;

namespace SafetyAppliaction.Controllers
{
    public class WorklistController : Controller
    {
        private readonly IWorklistService _worklistService;
        private readonly IUserService _userService;
        private readonly IRequestService _requestService;

        public WorklistController(IWorklistService worklistService, IUserService userService,  IRequestService requestService)
        {
            _worklistService = worklistService;
            _requestService = requestService;
            _userService = userService;
        }

        // GET: Worklist
        public async Task<IActionResult> Index()
        {
            var user = await _userService.GetLoggedInUser();
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var worklists = await _worklistService.GetPendingWorklistAsync(user.EmployeeId);
            return View(worklists);
        }

        
        public async Task<IActionResult> Details(int id)
        {
            var requestDetail = await _requestService.GetRequestDetailAsync(id); 
            if (requestDetail == null)
            {
                return NotFound();
            }

            return View(requestDetail); 
        }

        // POST: Worklist/Approve/5
        [HttpPost]
        public async Task<IActionResult> Approve(int id)
        {
            var user = await _userService.GetLoggedInUser();
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            await _worklistService.ApproveRequestAsync(id, user.EmployeeId);
            return RedirectToAction(nameof(Index));
        }

        // POST: Worklist/Reject/5
        [HttpPost]
        public async Task<IActionResult> Reject(int id)
        {
            var user = await _userService.GetLoggedInUser();
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            await _worklistService.RejectRequestAsync(id, user.EmployeeId);
            return RedirectToAction(nameof(Index));
        }

        // GET: Worklist/PendingWorklistCount
        public async Task<IActionResult> PendingWorklistCount()
        {
            var user = await _userService.GetLoggedInUser();
            if (user == null)
            {
                return Json(0);
            }

            var count = await _worklistService.GetPendingWorklistCountAsync(user.EmployeeId);
            return Json(count);
        }
    }
}
