using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace MaximusFramework.Functions
{
    public class SwitchTo
    {
        public static void Frame(string frame)
        {
            Start.GetDriver.SwitchTo().Frame(FindBy.Css(frame));
        }

        public static void Default()
        {
            Start.GetDriver.SwitchTo().DefaultContent();
        }

        public static void Tab(int count)
        {
            Start.GetDriver.SwitchTo().Window(Start.GetDriver.WindowHandles[count]);
        }

        public static void NewTab(string element)
        {
            new Actions(Start.GetDriver).KeyDown(Keys.Control).Click(Start.GetDriver.FindElement(By.Id(element))).Perform();
            Start.GetDriver.SwitchTo().Window(Start.GetDriver.WindowHandles.Last());
        }
    }
}
