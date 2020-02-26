using System;
using System.Diagnostics;
using System.Net.Http;
using BachelorProjectClient.Repository;
using BachelorProjectClient.Requests;
using BachelorProjectClient.Requests.RestRequests;

namespace BachelorProjectClient.TestCases.RestTestCases
{
    public class MongoTestCases
    {
        public static void testCase1(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMongoRequests.CreateTestCase1();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase1.ToString(),
                Enums.Enums.API.REST.ToString());
        }
    }
}
