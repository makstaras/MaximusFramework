using NUnit.Framework;

namespace MaximusFramework.Functions
{
    public class Compare
    {
        public static void Two(string first, string second)
        {
            Assert.That(first, Is.EqualTo(second));
        }
    }
}
