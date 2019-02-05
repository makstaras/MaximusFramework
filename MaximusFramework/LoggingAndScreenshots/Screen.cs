using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using Serilog;

namespace MaximusFramework
{
    public class Screen
    {
        public static void Take()
        {
            var screenshot = ((ITakesScreenshot)Start.GetDriver).GetScreenshot();
            var destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MaximusFramework";
            string curentDateTime = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
            System.IO.Directory.CreateDirectory(destinationPath);
            var screenshotPath = Path.Combine(destinationPath, "Screenshot " + curentDateTime + ".png");
            screenshot.SaveAsFile(screenshotPath);
            TestContext.AddTestAttachment(screenshotPath);
            Log.Information("Screenshot is created");
        }

        public static void OnFail()
        {
            string CurentDateTime = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
            Screenshot screenshot = ((ITakesScreenshot)Start.GetDriver).GetScreenshot();
            screenshot.SaveAsFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MaximusFramework\Exception " + CurentDateTime + @".png");
            Log.Information("Screenshot on fail is created");
        }
    }
}
