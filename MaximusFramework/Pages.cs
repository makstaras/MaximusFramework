using OpenQA.Selenium.Support.PageObjects;

namespace MaximusFramework
{
    public class Pages
    {
        public static T getPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Start.GetDriver, page);
            return page;
        }
    }
}