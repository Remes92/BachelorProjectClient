using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace BachelorProjectClient.Requests.GraphQLRequests
{
    public class GraphQLMongoRequests
    {
        public static HttpRequestMessage CreateTestCase1(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase1(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase2(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase2(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase3(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase3(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase4(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase4(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase5(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase5(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase6(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase6(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase7(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase7(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase8(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase8(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase9(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase9(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase10(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase10(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase11(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase11(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase12(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase12(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase13(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase13(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase14(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase14(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase15(int id)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase15(id)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase16(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase16(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase17(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase17(lower, upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase18(int lower, int upper)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(GraphQlBodyQuerys.CreateGraphQLBodyTestCase18(lower,upper)), Encoding.UTF8, "application/json");
            HttpRequestMessage request = GraphQLHttpRequests.MongoRequest();
            request.Content = content;
            return request;
        }
    }
}
