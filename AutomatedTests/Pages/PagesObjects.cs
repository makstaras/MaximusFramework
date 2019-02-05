using MaximusFramework;

namespace AutomatedTests
{
    public class PagesObjects : Pages
    {
        public static Login Login
        {
            get { return getPages<Login>(); }
        }
    }
}
