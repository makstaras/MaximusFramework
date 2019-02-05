using System.Linq;
using System.IO;
using NUnit.Framework;
using System.Collections;
using Serilog;

namespace MaximusFramework
{
    public class TestData
    {
        public static IEnumerable GetTestData
        {
            get
            {
                var path = System.IO.Directory.GetCurrentDirectory() + @"\DataDriven.txt";

                var valid = File.ReadAllLines(path)
                    .Skip(1)
                    .Where(s => !string.IsNullOrWhiteSpace(s));

                foreach (var day in valid)
                {
                    Log.Debug(day);
                    yield return new TestCaseData(day);
                }
            }
        }
    }
}
