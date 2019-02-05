using MaximusFramework;
using MaximusFramework.Functions;
using NUnit.Framework;

namespace AutomatedTests
{
    [TestFixture]
    public class FuncTests : FuncTestsSetup
    {
        [Test]
        [Author("Taras Maksymiv")]
        [Category("Contacts")]
        public void VerifyAddingNewContact()
        {
            string firstname;
            string lastname;
            string email;
            string city;
            string address;
            string phone;
            int count;

            var data = new FakeData().FillIn();
            firstname = data.FirstName;
            lastname = data.LastName;
            email = data.EmailAddress;
            city = data.City;
            address = data.Address;
            phone = data.Phone;
            count = data.Digit;
            Fluent.Contain(email, "@");
            Fluent.MatchRegex(email, @"[A-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}");

            FindBy.CssAndClick("#main-body > div > div > div.col-md-3.pull-md-left.sidebar.sidebar-secondary > div:nth-child(1) > div.panel-footer.clearfix > a");
            FindBy.IdAndSendKeys("inputFirstName", firstname);
            FindBy.IdAndSendKeys("inputLastName", lastname);
            FindBy.IdAndSendKeys("inputEmail", email);
            FindBy.IdAndSendKeys("inputCity", city);
            FindBy.IdAndSendKeys("inputAddress1", address);
            FindBy.IdAndSendKeys("inputPhone", phone);

            Logs.WriteToConsole(count.ToString());
            switch (count.ToString())
            {
                case "1": FindBy.IdAndClick("generalemails"); break;
                case "2": FindBy.IdAndClick("productemails"); break;
                case "3": FindBy.IdAndClick("domainemails"); break;
                case "4": FindBy.IdAndClick("invoiceemails"); break;
                case "5": FindBy.IdAndClick("supportemails"); break;
            }

            FindBy.NameAndClick("save");

            string successful = FindBy.CssAndGetText("#main-body > div > div > div.col-md-9.pull-md-right.main-content > div.alert.alert-success.text-center");
            Compare.Two(successful, "Changes Saved Successfully!");

            SwitchTo.Default();
        }

        [Test]
        [Author("Taras Maksymiv")]
        [Category("Contacts")]
        [TestCaseSource(typeof(TestData), "GetTestData")]
        public void VerifyEditingTheExistingContact(string DataFromFile)
        {
            var data = new FakeData().FillIn();
            string state = data.State;

            TestContext.WriteLine(DataFromFile);
            FindBy.ClassAndClick("list-group-item");
            FindBy.Id("inputCompanyName").Clear();
            FindBy.IdAndSendKeys("inputCompanyName", DataFromFile);
            FindBy.Id("stateinput").Clear();
            FindBy.IdAndSendKeys("stateinput", state);
            FindBy.NameAndClick("save");

            string successful = FindBy.CssAndGetText("#main-body > div > div > div.col-md-9.pull-md-right.main-content > div.alert.alert-success.text-center");
            Compare.Two(successful, "Changes Saved Successfully!");

            FindBy.IdAndClick("Primary_Navbar-Home");

            FindBy.ClassAndClick("list-group-item");
            Compare.Two(FindBy.IdAndGetTextAttribute("inputCompanyName"), DataFromFile);
        }

        [Test]
        [Author("Taras Maksymiv")]
        [Category("Navigation")]
        public void VerifyNavigationToSupportTickets()
        {
            FindBy.IdAndClick("Primary_Navbar-Support");
            SwitchTo.NewTab("Primary_Navbar-Support-Tickets");

            Start.VerifyBrowserTitle("Support Tickets - PHPTRAVELS");

            Screen.Take();
        }
    }
}
