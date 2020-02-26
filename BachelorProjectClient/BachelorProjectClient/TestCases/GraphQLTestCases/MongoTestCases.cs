using BachelorProjectClient.Repository;
using BachelorProjectClient.Requests;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BachelorProjectClient.Requests.GraphQLRequests;

namespace BachelorProjectClient.TestCases.GraphQLTestCases
{
    public class MongoTestCases
    {
        public static void testCase1(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase1();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase2.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase2(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase2();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase3.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase3(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase3();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase4.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase4(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase4();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase5.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase5(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase5();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase6.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase6(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase6();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase7.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase7(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase7();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase8.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase8(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase8();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase9.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase9(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase9();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase9.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase10(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase10();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase10.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase11(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase11();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase11.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase12(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase12();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase12.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase13(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase13();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase13.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase14(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase14();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase14.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase15(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase15();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase15.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase16(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase16();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase16.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase17(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase17();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase17.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
        public static void testCase18(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = GraphQLMongoRequests.CreateTestCase18();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase18.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
    }
}
