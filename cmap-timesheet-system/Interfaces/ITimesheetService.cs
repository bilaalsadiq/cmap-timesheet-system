using cmap_timesheet_system.Models;

namespace cmap_timesheet_system.Interfaces
{
    public interface ITimesheetService
    {
        void AddEntry(TimesheetEntry entry);
    }
}
