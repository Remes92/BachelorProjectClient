using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BachelorProjectClient.Repository;
using BachelorProjectClient.Requests;
using BachelorProjectClient.Requests.SoapRequests;

namespace BachelorProjectClient.TestCases.SoapTestCases
{
    public class MongoTestCases
    {
        public static void TestCase1(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase1();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase1.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase2(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase2();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase2.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase3(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase3();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase3.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase4(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase4();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase4.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase5(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase5();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase5.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase6(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase6();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase6.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase7(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase7();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase7.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase8(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase8();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase8.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase9(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase9();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase9.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase10(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase10();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase10.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase11(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase11();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase11.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase12(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase12();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase12.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase13(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase13();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase13.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase14(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase14();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase14.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase15(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase15();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase15.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase16(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase16();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase16.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase17(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase17();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase17.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
        public static void TestCase18(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMongoRequests.CreateTestCase18();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.Mongo.ToString(),
                Enums.Enums.TestCases.TestCase18.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }

    }
}
