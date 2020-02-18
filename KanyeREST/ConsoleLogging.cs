using System;
using System.Net.Http;
using System.Threading;

namespace KanyeREST
{
    internal class ConsoleLogging
    {
        internal static void Sleep(int milliSeconds)
        {
            Console.WriteLine();
            Thread.Sleep(milliSeconds);
        }

        internal static void Chat(HttpClient client, string kanyeURL, string swansonURL, int chatDelayMilliSeconds = 1000)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {BaseServiceCalls.GetKanyeQuote(client, kanyeURL)}");
                Sleep(chatDelayMilliSeconds);
                Console.WriteLine($"Ron: {BaseServiceCalls.GetSwansonQuote(client, swansonURL)}");
                Sleep(chatDelayMilliSeconds);
            }
        }
    }
}