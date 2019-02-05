using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MaximusFramework.Functions
{
    public class Fluent
    {
        public static void Be(string element, string value)
        {
            element.Should().Be(value);
        }

        public static void MatchRegex(string element, string regex)
        {
            element.Should().MatchRegex(regex);
        }

        public static void Contain(string element, string value)
        {
            element.Should().Contain(value);
        }

        public static void Select(string dropdownId, string dropdownItem)
        {
            IWebElement dropdown = Start.GetDriver.FindElement(By.Id(dropdownId));
            SelectElement selectItem = new SelectElement(dropdown);
            selectItem.SelectByText(dropdownItem);
        }
    }
}
