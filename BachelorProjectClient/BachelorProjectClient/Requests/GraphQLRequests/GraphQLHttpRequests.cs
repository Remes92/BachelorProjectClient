using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests
{
    public class GraphQLHttpRequests
    {
        private const string apiUrlMongo = "https://localhost:44377/api/graphqlmongo/";
        private const string apiUrlSql = "https://localhost:44377/api/graphqlmysql/";
        public static HttpRequestMessage MongoRequest()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(apiUrlMongo)
            };
            return request;
        }

        public static HttpRequestMessage MySqlRequest()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(apiUrlSql)
            };
            return request;
        }
    }
}
