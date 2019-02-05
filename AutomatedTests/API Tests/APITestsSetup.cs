using NUnit.Framework;
using MaximusFramework;

namespace AutomatedTests
{
    [TestFixture]
    public class APITestsSetup : CoreAutomation
    {
        string ApiURL = "https://jsonplaceholder.typicode.com/";

        [SetUp]
        public void setup()
        {
            //APISetup.Initialize(ApiURL);
            APISetup.Initialize("Firefox", ApiURL);
        }
    }
}
