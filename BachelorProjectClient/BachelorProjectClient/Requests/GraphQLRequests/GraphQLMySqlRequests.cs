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

        public static HttpRequestMessage CreateTestCase2()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase2()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase3()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase3()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase4()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase4()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase5()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase5()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase6()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase6()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase7()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase7()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase8()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase8()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase9()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase9()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase10()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase10()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase11()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase11()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase12()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase12()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase13()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase13()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase14()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase14()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase15()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase15()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase16()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase16()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase17()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase17()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase18()
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase18()), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MySqlRequest();
            request.Content = content;
            return request;
        }

    }
}
