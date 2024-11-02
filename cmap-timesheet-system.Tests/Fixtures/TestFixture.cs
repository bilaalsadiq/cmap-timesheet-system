using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cmap_timesheet_system.Data;
using cmap_timesheet_system.Interfaces;
using cmap_timesheet_system.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace cmap_timesheet_system.Tests.Fixtures
{
    public class TestFixture : IDisposable
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public TestFixture()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase(Guid.NewGuid().ToString()));

            serviceCollection.AddTransient<ITimesheetService, TimesheetService>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public void Dispose()
        {
            ServiceProvider?.Dispose();
        }
    }
}
