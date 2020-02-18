using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        const string kanyeURL = @"https://api.kanye.rest";
        const string swansonURL = @"https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                ConsoleLogging.Chat(client, kanyeURL, swansonURL);
            }
        }        
    }
}
