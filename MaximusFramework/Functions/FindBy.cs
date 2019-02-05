using OpenQA.Selenium;
using System.Linq;
using System.Collections.Generic;

namespace MaximusFramework
{
    public class FindBy
    {
        /// <summary>
        /// LINKED TEXT
        /// </summary>
        public static IWebElement Text(string elementText)
        {
            return Start.GetDriver.FindElement(By.LinkText(elementText));
        }

        public static void TextAndClick(string elementText)
        {
            Start.GetDriver.FindElement(By.LinkText(elementText)).Click();
        }

        public static IWebElement TextAndToVar(string elementText)
        {
            return Start.GetDriver.FindElement(By.LinkText(elementText));
        }

        public static List<IWebElement> TextAndToList(string elementText)
        {
            return Start.GetDriver.FindElements(By.LinkText(elementText)).ToList();
        }

        public static void TextAndSendKeys(string elementText, string value)
        {
            Start.GetDriver.FindElement(By.LinkText(elementText)).SendKeys(value);
        }

        public static string TextAndGetTextAttribute(string elementText)
        {
            IWebElement element = Start.GetDriver.FindElement(By.LinkText(elementText));
            string getElementText = element.GetAttribute("value");
            return getElementText;
        }

        public static string TextAndGetText(string elementText)
        {
            return Start.GetDriver.FindElement(By.LinkText(elementText)).Text;
        }

        /// <summary>
        /// ID
        /// </summary>
        public static IWebElement Id(string elementId)
        {
            return Start.GetDriver.FindElement(By.Id(elementId));
        }

        public static void IdAndClick(string elementId)
        {
            Start.GetDriver.FindElement(By.Id(elementId)).Click();
        }

        public static IWebElement IdAndToVar(string elementId)
        {
            return Start.GetDriver.FindElement(By.Id(elementId));
        }

        public static List<IWebElement> IdAndToList(string elementId)
        {
            return Start.GetDriver.FindElements(By.Id(elementId)).ToList();
        }

        public static void IdAndSendKeys(string elementId, string value)
        {
            Start.GetDriver.FindElement(By.Id(elementId)).SendKeys(value);
        }

        public static string IdAndGetTextAttribute(string elementId)
        {
            IWebElement element = Start.GetDriver.FindElement(By.Id(elementId));
            string getElementText = element.GetAttribute("value");
            return getElementText;
        }

        public static string IdAndGetText(string elementId)
        {
            return Start.GetDriver.FindElement(By.Id(elementId)).Text;
        }

        /// <summary>
        /// CLASSNAME
        /// </summary>
        public static IWebElement Class(string elementClass)
        {
            return Start.GetDriver.FindElement(By.ClassName(elementClass));
        }

        public static void ClassAndClick(string elementClass)
        {
            Start.GetDriver.FindElement(By.ClassName(elementClass)).Click();
        }

        public static IWebElement ClassAndToVar(string elementClass)
        {
            return Start.GetDriver.FindElement(By.ClassName(elementClass));
        }

        public static List<IWebElement> ClassAndToList(string elementClass)
        {
            return Start.GetDriver.FindElements(By.ClassName(elementClass)).ToList();
        }

        public static void ClassAndSendKeys(string elementClass, string value)
        {
            Start.GetDriver.FindElement(By.ClassName(elementClass)).SendKeys(value);
        }

        public static string ClassAndGetTextAttribute(string elementClass)
        {
            IWebElement element = Start.GetDriver.FindElement(By.ClassName(elementClass));
            string getElementText = element.GetAttribute("value");
            return getElementText;
        }

        public static string ClassAndGetText(string elementClass)
        {
            return Start.GetDriver.FindElement(By.ClassName(elementClass)).Text;
        }

        /// <summary>
        /// NAME
        /// </summary>
        public static IWebElement Name(string elementName)
        {
            return Start.GetDriver.FindElement(By.Name(elementName));
        }

        public static void NameAndClick(string elementName)
        {
            Start.GetDriver.FindElement(By.Name(elementName)).Click();
        }

        public static IWebElement NameAndToVar(string elementName)
        {
            return Start.GetDriver.FindElement(By.Name(elementName));
        }

        public static List<IWebElement> NameAndToList(string elementName)
        {
            return Start.GetDriver.FindElements(By.Name(elementName)).ToList();
        }

        public static void NameAndSendKeys(string elementName, string value)
        {
            Start.GetDriver.FindElement(By.Name(elementName)).SendKeys(value);
        }

        public static string  NameAndGetTextAttribute(string elementName)
        {
            IWebElement element = Start.GetDriver.FindElement(By.Name(elementName));
            string getElementText = element.GetAttribute("value");
            return getElementText;
        }

        public static string NameAndGetText(string elementName)
        {
            return Start.GetDriver.FindElement(By.Name(elementName)).Text;
        }

        /// <summary>
        /// XPATH
        /// </summary>
        public static IWebElement XPath(string elementXPath)
        {
            return Start.GetDriver.FindElement(By.XPath(elementXPath));
        }

        public static void XPathAndClick(string elementXPath)
        {
            Start.GetDriver.FindElement(By.XPath(elementXPath)).Click();
        }

        public static IWebElement XPathAndToVar(string elementXPath)
        {
            return Start.GetDriver.FindElement(By.XPath(elementXPath));
        }

        public static List<IWebElement> XPathAndToList(string elementXPath)
        {
            return Start.GetDriver.FindElements(By.XPath(elementXPath)).ToList();
        }

        public static void XPathAndSendKeys(string elementXPath, string value)
        {
            Start.GetDriver.FindElement(By.XPath(elementXPath)).SendKeys(value);
        }

        public static string XPathAndGetTextAttribute(string elementXPath)
        {
            IWebElement element = Start.GetDriver.FindElement(By.XPath(elementXPath));
            string getElementText = element.GetAttribute("value");
            return getElementText;
        }

        public static string XPathAndGetText(string elementXPath)
        {
            return Start.GetDriver.FindElement(By.XPath(elementXPath)).Text;
        }

        /// <summary>
        /// CSS SELECTOR
        /// </summary>
        public static IWebElement Css(string elementCss)
        {
            return Start.GetDriver.FindElement(By.CssSelector(elementCss));
        }

        public static void CssAndClick(string elementCss)
        {
            Start.GetDriver.FindElement(By.CssSelector(elementCss)).Click();
        }

        public static IWebElement CssAndToVar(string elementCss)
        {
            return Start.GetDriver.FindElement(By.CssSelector(elementCss));
        }

        public static List<IWebElement> CssAndToList(string elementCss)
        {
            return Start.GetDriver.FindElements(By.CssSelector(elementCss)).ToList();
        }

        public static void CssAndSendKeys(string elementCss, string value)
        {
            Start.GetDriver.FindElement(By.CssSelector(elementCss)).SendKeys(value);
        }

        public static string CssAndGetTextAttribute(string elementCss)
        {
            IWebElement element = Start.GetDriver.FindElement(By.CssSelector(elementCss));
            string getElementText = element.GetAttribute("value");
            return getElementText;
        }

        public static string CssAndGetText(string elementCss)
        {
            return Start.GetDriver.FindElement(By.CssSelector(elementCss)).Text;
        }
    }
}
