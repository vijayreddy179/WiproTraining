using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace UserManagementApp.Services
{
    public static class Logging
    {
        static Logging()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs\\app.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public static void LogInfo(string message)
        {
            Log.Information(message);
        }

        public static void LogError(Exception ex)
        {
            Log.Error(ex, ex.Message);
        }
    }
}
