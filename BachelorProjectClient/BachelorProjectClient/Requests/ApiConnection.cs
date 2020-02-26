using BachelorProjectClient.Repository;
using BachelorProjectClient.Requests;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests
{
    public class ApiConnection
    {
        public static void RunTestcase(int executionNO, int iteration, int clientId,HttpRequestMessage request,string db,string testcase,string api)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            HttpResponseMessage response = SendToAPI(request);
            stopWatch.Stop();



            LogDatabase.insertToLogDb(clientId, stopWatch.ElapsedMilliseconds,
                request.ToString().Length,
                request.Content == null ? 0 : request.Content.Headers.ContentLength,
                response.Headers.ToString().Length,
                response.Content.Headers.ContentLength == null ? 0 : response.Content.Headers.ContentLength,
                executionNO, iteration, db, testcase, api);
        }
        private static HttpResponseMessage SendToAPI(HttpRequestMessage request)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage re = client.SendAsync(request).Result;
                if (re.IsSuccessStatusCode)
                {
                    return re;
                }
                return null;
            }
        }
    }
}
