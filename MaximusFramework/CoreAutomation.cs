using System;
using NUnit.Framework;
using Serilog;
using Serilog.Context;

namespace MaximusFramework
{
    [TestFixture]
    public class CoreAutomation
    {
        [SetUp]
        public void setup()
        {
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MaximusFramework\");
            Logs.DetailedLogger("");
        }

        [TearDown]
        public void tearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status.ToString() == "Failed")
            {
                var stackTrace = TestContext.CurrentContext.Result.StackTrace;
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Log.Error(errorMessage + " : " + stackTrace);

                using (LogContext.PushProperty("TestsResult", "FAILED"))
                {
                    Log.Information("Suite is Failed. But used LogContext property (this one) and ColoredConsole for hw additional tasks");
                }

                Screen.OnFail();
            }

            Start.BrowserClose();
            Logs.CloseLogger();
        }
    }
}
