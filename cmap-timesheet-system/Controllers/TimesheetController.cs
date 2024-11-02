using cmap_timesheet_system.Models;
using cmap_timesheet_system.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cmap_timesheet_system.Controllers
{
    public class TimesheetController : Controller
    {
        private readonly ITimesheetService _service;
        public TimesheetController(ITimesheetService service)
        {
            _service = service;    
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEntry(TimesheetEntry entry)
        {
            _service.AddEntry(entry);
            return RedirectToAction("Index");
        }
    }
}
