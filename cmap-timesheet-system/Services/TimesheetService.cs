using cmap_timesheet_system.Data;
using cmap_timesheet_system.Interfaces;
using cmap_timesheet_system.Models;

namespace cmap_timesheet_system.Services
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ApplicationDbContext _context;

        public TimesheetService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEntry(TimesheetEntry entry)
        {
            _context.TimesheetEntries.Add(entry);
            _context.SaveChanges();
        }
    }
}
