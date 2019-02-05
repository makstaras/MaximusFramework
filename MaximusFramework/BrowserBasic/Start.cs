using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using Serilog;

namespace MaximusFramework
{
    public class Start
    {
        private static IWebDriver webDriver;

        public static void Init(string browser, string url)
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    Log.Debug("ChromeDriver is started");
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver(BrowOptions.FirefoxHeadless());
                    Log.Debug("FirefoxDriver is started");
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    Log.Debug("InternetExplorerDriver is started");
                    break;  
            }

            webDriver.Manage().Window.Maximize();
            BrowserNavigateTo(url);
        }

        public static string GetTitle
        {
            get { return webDriver.Title; }
        }

        public static IWebDriver GetDriver
        {
            get { return webDriver; }
        }

        public static void Reload()
        {
            GetDriver.Navigate().Refresh();
        }

        public static void BrowserNavigateTo(string url)
        {
            webDriver.Url = url;
            Log.Debug("Navigation to " + url);
        }

        public static void BrowserClose()
        {
            webDriver.Quit();
            Log.Debug("webDriver is closed");
        }

        public static void VerifyBrowserURL(string url)
        {
            IWebDriver driver = Start.GetDriver;
            string PageURL = driver.Url;
            string message = "The Current Url and Expected Url are not equals";
            if (PageURL.Equals(url))
                Log.Debug("URL is correct, functional tests can be executed");
            else
                Log.Debug("URL is incorrect, functional tests can not be executed here");
            Assert.AreEqual(PageURL, url, message);
        }

        public static void VerifyBrowserTitle(string title)
        {
            IWebDriver driver = Start.GetDriver;
            string PageTitle = driver.Title;
            string message = "The Current Title and Expected Title are not equals";
            if (PageTitle.Equals(title))
                Log.Debug("Page Title is correct, functional tests can be executed");
            else
                Log.Debug("Page Title is incorrect, functional tests can not be executed here");
            Assert.AreEqual(PageTitle, title, message);
        }

        public static void VerifyElementNotAppear(IWebElement element)
        {
            if (!element.Displayed)
            {
                string message = "Element does not exist";
                Assert.Fail(message);
                Log.Debug("Element isn't displayed on the page");
            }
        }
    }
}
