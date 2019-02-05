using System;
using Serilog;
using Serilog.Events;

namespace MaximusFramework
{
    public class Logs
    {
        public static void DetailedLogger(string CustomPath)
        {
            string CurentDateTime;
            string WorkDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            CurentDateTime = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);

            if (CustomPath != "") WorkDirectoryPath = CustomPath;

            Log.Logger = new LoggerConfiguration()
                .WriteTo.ColoredConsole(outputTemplate: "[{Timestamp:HH:mm:ss}{Level:u3}] {Message:lj}{NewLine}{Exception} ProcessId:{ProcessId} ThreadId:{ThreadId} ProcessName:{ProcessName}")
                .MinimumLevel.Debug()
                .WriteTo.File(WorkDirectoryPath + @"\MaximusFramework\" + CurentDateTime + @"\detailedLogs.txt")
                .Enrich.WithProcessId()
                .Enrich.WithThreadId()
                .Enrich.WithProcessName()
                .Enrich.FromLogContext()
                .CreateLogger();
            Log.Information("Logger is added");
        }

        public static void InformationLogger(string CustomPath)
        {
            string CurentDateTime;
            string WorkDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            CurentDateTime = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);

            if (CustomPath != "") WorkDirectoryPath = CustomPath;

            Log.Logger = new LoggerConfiguration()
                .WriteTo.ColoredConsole(outputTemplate: "[{Timestamp:HH:mm:ss}{Level:u3}] {Message:lj}{NewLine}{Exception} ProcessId:{ProcessId} ThreadId:{ThreadId} ProcessName:{ProcessName}")
                .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Information || e.Level == LogEventLevel.Error)
                    .WriteTo.File(WorkDirectoryPath + @"\MaximusFramework\" + CurentDateTime + @"\logs.txt"))
                .Enrich.WithProcessId()
                .Enrich.WithThreadId()
                .Enrich.WithProcessName()
                .Enrich.FromLogContext()
                .CreateLogger();
            Log.Information("Logger is added");
        }

        //Other types of Logger can be added in the next builds

        public static void WriteToConsole(string value)
        {
            Console.WriteLine(value);
        }

        public static void CloseLogger()
        {
            Log.Information("Logger is closed");
            Log.CloseAndFlush();
        }
    }
}
