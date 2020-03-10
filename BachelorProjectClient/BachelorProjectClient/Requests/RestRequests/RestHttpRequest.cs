using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests 
{
    class RestHttpRequest
    {
        private const string apiUrlMongo = "http://192.168.128.63/api/restmongo/";
        private const string apiUrlSql = "http://192.168.128.63/api/restmysql/";
        public static HttpRequestMessage MongoRequest(string testcase)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(apiUrlMongo+testcase)
            };
            return request;
        } 
        public static HttpRequestMessage MySqlRequest(string testcase)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(apiUrlSql + testcase)
            };
            return request;
        }
    }
}
