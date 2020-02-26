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
            HttpRequestMessage request = Requests.GraphQLRequests.GraphQLMongoRequests.CreateTestCase1();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase1.ToString(),
                Enums.Enums.API.GRAPHQL.ToString());

        }
    }
}
