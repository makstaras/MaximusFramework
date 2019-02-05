using MaximusFramework;
using NUnit.Framework;

namespace AutomatedTests
{
    [TestFixture]
    public class APITests : APITestsSetup
    {
        [Test]
        public void APIGetComment1()
        {
            string email = API.GETMethod("/comments/1", "email");
            StringAssert.AreEqualIgnoringCase(email, "Eliseo@gardner.biz");
        }

        [Test]
        public void APIPostComment()
        {
            string id = API.POSTMethod("/posts/7/comments", "id");
            StringAssert.AreEqualIgnoringCase(id, "501");
        }

        [Test]
        public void APIPostPhotos()
        {
            string id = API.POSTMethod("/photos", "id");
            StringAssert.AreEqualIgnoringCase(id, "5001");
        }
    }
}
