using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MaximusFramework
{
    public class BrowOptions
    {
        public static FirefoxOptions FirefoxHeadless()
        {
            var options = new FirefoxOptions();

            options.AddArguments
                (
                    "-headless"
                );
            return options;
        }

        // Headless option for other browsers will be added in the next build

        public static ChromeOptions ChromeDeviceEmulation(string device)
        {
            var options = new ChromeOptions();
            options.EnableMobileEmulation(device);
            return options;
        }
    }   
}
