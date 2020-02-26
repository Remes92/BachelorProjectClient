using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BachelorProjectClient.Requests.GraphQLRequests;

namespace BachelorProjectClient.Requests.GraphQLRequests
{
    public class GraphQLMySqlRequests
    {
        public static HttpRequestMessage CreateTestCase1()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase1()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }

    }
}
