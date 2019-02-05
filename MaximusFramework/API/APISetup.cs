using Newtonsoft.Json.Linq;
using RestSharp;
using Serilog;

namespace MaximusFramework
{
    public class APISetup
    {
        private static string BaseUrl { get; set; }
        public static RestClient Client { get; set; }
        public static RestRequest Request { get; set; }
        public static IRestResponse Response { get; set; }
        public static JObject ResponseJson { get; set; }
        
        public static void Initialize(string browser, string url)
        {
            Log.Information("RestClient is ready");
            BaseUrl = url;
            Client = new RestClient
            {
                BaseUrl = new System.Uri(BaseUrl),
                Timeout = System.Convert.ToInt32(System.TimeSpan.FromMinutes(3).TotalMilliseconds)
            };
            Start.Init(browser, url);
        }
    }
}
