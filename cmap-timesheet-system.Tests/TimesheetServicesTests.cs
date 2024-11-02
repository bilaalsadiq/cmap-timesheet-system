using cmap_timesheet_system.Data;
using cmap_timesheet_system.Interfaces;
using cmap_timesheet_system.Models;
using cmap_timesheet_system.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using cmap_timesheet_system.Tests.Fixtures;
using Microsoft.Extensions.DependencyInjection;

namespace cmap_timesheet_system.Tests
{
    public class TimesheetServicesTests : IClassFixture<TestFixture>
    {

        private readonly ITimesheetService _service;
        private readonly ApplicationDbContext _context;

        public TimesheetServicesTests(TestFixture fixture)
        {
            _service = fixture.ServiceProvider.GetService<ITimesheetService>();
            _context = fixture.ServiceProvider.GetService<ApplicationDbContext>();
        }

        [Fact]
        public void AddSingleEntry_ShouldAddEntryToDB()
        {
            //arrange
            var entry = new TimesheetEntry()
            {
                UserName = "John Smith",
                Date = new DateTime(2014 / 10 / 22),
                ProjectName = "Project Alpha",
                TaskDescription = "Developed new feature X",
                HoursWorked = 4
            };

            //act
            _service.AddEntry(entry);

            //assert
            Assert.Single(_context.TimesheetEntries);
        }
    }
}