using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using Serilog;
using System.Linq;
using System.Net;

namespace MaximusFramework
{
    public class API : APISetup
    {
        public static string GETMethod(string request, string token)
        {
            Log.Debug("GET Method is started");
            Request = new RestRequest(request, Method.GET);
            Response = Client.Get(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            ResponseJson = JObject.Parse(Response.Content);
            string email = (string)ResponseJson.SelectTokens(token).FirstOrDefault();
            Log.Information("GET Method is finished");
            return email;
        }

        public static string POSTMethod(string request, string token)
        {
            Log.Debug("POST Method is started");
            Request = new RestRequest(request, Method.POST);
            Response = Client.Post(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            ResponseJson = JObject.Parse(Response.Content);
            string id = (string)ResponseJson.SelectTokens(token).FirstOrDefault();
            Log.Information("POST Method is finished");
            return id;
        }
    }
}
