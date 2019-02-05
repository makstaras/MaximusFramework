using NUnit.Framework;
using MaximusFramework;

namespace AutomatedTests
{
    [TestFixture]
    public class FuncTestsSetup : CoreAutomation
    {
        string functionalURL = "https://phptravels.com/";
        
        [SetUp]
        public void setup()
        {
            Start.Init("Chrome", functionalURL);

            PagesObjects.Login.GoToPage();
            PagesObjects.Login.IsAt();
            PagesObjects.Login.SendYourEmail();
            PagesObjects.Login.SendYourPassword();
            PagesObjects.Login.Submit();
        }

        [TearDown]
        public void teardown()
        {
            FindBy.XPathAndClick("//*[@id='header']/div/ul/li[3]/a");
            Start.BrowserNavigateTo("https://phptravels.com/");
        }
    }
}
