using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyAppliaction.Services;
using SafetyApplication.Data;
using SafetyApplication.Models;
using System.Transactions;

namespace SafetyAppliaction.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IRequestService _requestService;
        private readonly IStatusService _statusService;
        private readonly IUserService _userService;
        private readonly IWorklistService _worklistService;
        private readonly AppDbContext _context;

        public RequestsController(
        IEmployeeService employeeService,
        IStatusService statusService,
        IRequestService requestService,
        IUserService userService,
        IWorklistService worklistService,
        AppDbContext context) 
        {
            _employeeService = employeeService;
            _statusService = statusService;
            _requestService = requestService;
            _userService = userService;
            _worklistService = worklistService;
            _context = context; 
        }

        public async Task<IActionResult> Index()
        {
            var requests = await _requestService.GetAllRequestsAsync();
            return View(requests);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _requestService.GetRequestByIdAsync(id.Value);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var employees = await _employeeService.GetAllEmployees();
            var statuses = await _statusService.GetStatusesAsync();
            var user = _userService.GetLoggedInUser();

            ViewData["Instructors"] = new SelectList((System.Collections.IEnumerable)employees, "EmployeeId", "EmployeeName");
            ViewData["Attendants"] = new SelectList((System.Collections.IEnumerable)employees, "EmployeeId", "EmployeeName");
            ViewData["Statuses"] = new SelectList(statuses, "StatusId", "StatusName");

            var model = new RequestViewModel
            {
                Company = "PT NSI",
                Departement = "IT",
                Section = "Shift 1", 
                Date = DateTime.Now,
                Time = DateTime.Now.TimeOfDay,
                CreateBy = "System",
                ApprovalStage = 1, 
                Status = "Waiting Checking",
                FormNo = _requestService.GenerateFormNumber("NSI","IT",4, DateTime.Now)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(
     [FromForm] string title,
     [FromForm] string potentialDangerousPoint,
     [FromForm] string theMostDangerPoint,
     [FromForm] string keyWord,
     [FromForm] string formNo,
     [FromForm] List<int> instructorIds,
     [FromForm] List<int> attendantIds,
     [FromForm] string section,
     [FromForm] string company)
        {
            // Ambil user yang sedang login
            var user = await _userService.GetLoggedInUser();
            var nextApprover = await _context.Departements
                .Where(d => d.DepartmentId == user.Employee.DepartmentId)
                .Select(d => d.AdminId)
                .FirstOrDefaultAsync();
            // Buat objek Request
            var request = new Request
            {
                Title = title,
                PotentialDangerousPoint = potentialDangerousPoint,
                TheMostDangerPoint = theMostDangerPoint,
                KeyWord = keyWord,
                FormNo = formNo,
                Departement = user.Employee.Departements.DepartmentName,
                Section = section,
                Date = DateTime.Now,
                Time = DateTime.Now.TimeOfDay,
                Company = company,
                StatusId = 1,
                ApprovalStage = 1,
                CreateDate = DateTime.Now,
                CreateBy = user?.Employee?.EmployeeName ?? "System",
                NextApprover = nextApprover
            };

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    await _requestService.CreateRequestAsync(request, instructorIds, attendantIds);
                    var worklist = new Worklist
                    {
                        RequestId = request.RequestId,
                        Approver = "Unknown Approver",
                        StatusId = 1,
                        CreateDate = DateTime.Now,
                        CreateBy = user?.Employee?.EmployeeName ?? "System",
                        ApprovalStage = 1
                    };

                    
                    await _worklistService.AddWorklistAsync(request);

                   
                    await transaction.CommitAsync();
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return Json(new { success = false, message = ex.Message });
                }
            }
        }


        //[HttpPost]
        //public async Task<IActionResult> Create(
        //     [FromForm] string title,
        //     [FromForm] string potentialDangerousPoint,
        //     [FromForm] string theMostDangerPoint,
        //     [FromForm] string keyWord,
        //     [FromForm] string formNo,
        //     [FromForm] List<int> instructorIds,
        //     [FromForm] List<int> attendantIds,
        //     [FromForm] string section,
        //     [FromForm] string company)
        //{
        //    // Ambil user yang sedang login
        //    var user = await _userService.GetLoggedInUser();

        //    // Buat objek Request
        //    var request = new Request
        //    {
        //        Title = title,
        //        PotentialDangerousPoint = potentialDangerousPoint,
        //        TheMostDangerPoint = theMostDangerPoint,
        //        KeyWord = keyWord,
        //        FormNo = formNo,
        //        Departement = "IT",
        //        Section = section,
        //        Date = DateTime.Now,
        //        Time = DateTime.Now.TimeOfDay,
        //        Company = company,
        //        StatusId = 1,
        //        ApprovalStage = 1,
        //        CreateDate = DateTime.Now,
        //        CreateBy = user?.Employee?.EmployeeName ?? "System"
        //    };

        //    try
        //    {
        //        // 1. Simpan request dan instruktur serta attendan terkait dalam satu service call
        //        await _requestService.CreateRequestAsync(request, instructorIds, attendantIds);

        //        // 2. Tentukan approver berdasarkan ApprovalStage pertama
        //       // var approver = await _employeeService.GetApproverByStage(user?.Employee?.DepartmentId, 1);

        //        // Buat objek Worklist untuk persetujuan
        //        var worklist = new Worklist
        //        {
        //            RequestId = request.RequestId,
        //            Approver =  "Unknown Approver",
        //            StatusId = 1,
        //            CreateDate = DateTime.Now,
        //            CreateBy = user?.Employee?.EmployeeName ?? "System",
        //            ApprovalStage = 1
        //        };

        //        // 3. Simpan worklist ke dalam tabel Worklist
        //        await _worklistService.AddWorklistAsync(worklist.RequestId, worklist.ApprovalStage, worklist.CreateBy);

        //        return Json(new { success = true });
        //    }
        //    catch (Exception ex)
        //    {
        //        // Kembalikan error dengan pesan
        //        return Json(new { success = false, message = ex.Message });
        //    }
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("RequestId,Title,PotentialDangerousPoint,TheMostDangerPoint,KeyWord,FormNo,Departement,Section,Date,Time,Company,StatusId,ApprovalStage,CreateDate,CreateBy,UpdateDate,UpdateBy")] Request request)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _requestService.CreateRequestAsync(request);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["StatusId"] = new SelectList( await _requestService.GetStatusesAsync(), "StatusId", "StatusId", request.StatusId);
        //    return View(request);
        //}
        //[HttpPost]
        //public IActionResult Create(
        //        string title,
        //        string potentialDangerousPoint,
        //        string theMostDangerPoint,
        //        string keyWord,
        //        string formNo,
        //        List<int> instructorIds,
        //        List<int> attendantIds,
        //        string section,
        //        string company)
        //{

        //    var model = new RequestViewModel
        //    {
        //        Title = title,
        //        PotentialDangerousPoint = potentialDangerousPoint,
        //        TheMostDangerPoint = theMostDangerPoint,
        //        KeyWord = keyWord,
        //        FormNo = formNo,
        //        InstructorIds = instructorIds,
        //        AttendantIds = attendantIds,
        //        Section = section,
        //        Company = company
        //    };

        //    if (ModelState.IsValid)
        //    {
        //        // Simpan model ke database
        //        // Misalnya: _context.Requests.Add(model);
        //        // _context.SaveChanges();

        //        return Json(new { success = true });
        //    }
        //    else
        //    {
        //        return Json(new { success = false });
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(
        //         string title,
        //         string potentialDangerousPoint,
        //         string theMostDangerPoint,
        //         string keyWord,
        //         string formNo,
        //         List<int> instructorIds,
        //         List<int> attendantIds,
        //         string section,
        //         string company)
        //{
        //    var user =await _userService.GetLoggedInUser();
        //    var request = new Request
        //    {
        //        Title = title,
        //        PotentialDangerousPoint = potentialDangerousPoint,
        //        TheMostDangerPoint = theMostDangerPoint,
        //        KeyWord = keyWord,
        //        FormNo = formNo,
        //        Departement = "IT", 
        //        Section = section,
        //        Date = DateTime.Now,
        //        Time = DateTime.Now.TimeOfDay,
        //        Company = company,
        //        StatusId = 1, 
        //        ApprovalStage = 1, 
        //        CreateDate = DateTime.Now,
        //        CreateBy = "Alan"
        //    };

        //    try
        //    {
        //        // 1. Simpan request ke tabel Requests
        //        await _requestService.CreateRequestAsync(request);

        //        // 2. Simpan instruktur ke tabel RequestInstructors
        //        foreach (var instructorId in instructorIds)
        //        {
        //            await _requestService.AddInstructorToRequestAsync(request.RequestId, instructorId);
        //        }

        //        // 3. Simpan attendan ke tabel RequestAttendants
        //        foreach (var attendantId in attendantIds)
        //        {
        //            await _requestService.AddAttendantToRequestAsync(request.RequestId, attendantId);
        //        }

        //        // 4. Input data ke Worklist sesuai ApprovalStage
        //        var approver = _employeeService.GetApproverByStage(user?.Employee?.DepartmentId, 1); 
        //        var worklist = new Worklist
        //        {
        //            RequestId = request.RequestId,
        //            Approver = approver.ToString(),
        //            StatusId = 1, 
        //            CreateDate = DateTime.Now,
        //            CreateBy = user.Employee.EmployeeName,
        //            ApprovalStage = 1

        //        };

        //        await _worklistService.AddWorklistAsync(worklist.RequestId,worklist.ApprovalStage, worklist.CreateBy);

        //        return Json(new { success = true });
        //    }
        //    catch (Exception ex) 
        //    {
        //        return Json(new { success = false });
        //    }
        //}


    }

}
