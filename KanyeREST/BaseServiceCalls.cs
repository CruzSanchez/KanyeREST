using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeREST
{
    static class BaseServiceCalls
    {
        public static string GetKanyeQuote(HttpClient client, string url)
        {
            var kanyeResponse = client.GetStringAsync(url).Result;

            return JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        }
        
        public static string GetSwansonQuote(HttpClient client, string url)
        {
            var swansonResponse = client.GetStringAsync(url).Result;

            return JArray.Parse(swansonResponse).First.ToString();
        }
    }
}
