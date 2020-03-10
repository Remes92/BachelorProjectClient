using System;
using System.Diagnostics;
using System.Net.Http;
using BachelorProjectClient.Repository;
using BachelorProjectClient.Requests;
using BachelorProjectClient.Requests.RestRequests;
using BachelorProjectClient.Enums;

namespace BachelorProjectClient.TestCases.RestTestCases
{
    public class MongoTestCases
    {
        public static void TestCase1(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase1(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase1.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase2(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase2(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase2.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase3(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase3(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase3.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase4(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase4(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase4.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase5(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase5(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase5.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase6(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase6(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase6.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase7(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase7(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase7.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase8(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase8(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase8.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase9(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase9(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase9.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase10(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase10(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase10.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase11(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase11(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase11.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase12(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase12(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase12.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase13(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase13(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase13.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase14(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase14(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase14.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase15(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase15(clientId * iteration);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase15.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase16(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase16(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase16.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase17(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase17(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase17.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase18(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase18(clientId * iteration, clientId * iteration + 100);
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase18.ToString(),
                Enums.Enums.API.REST.ToString());
        }
    }
}
