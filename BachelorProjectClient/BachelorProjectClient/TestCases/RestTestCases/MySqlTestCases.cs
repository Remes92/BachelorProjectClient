﻿using System;
using System.Diagnostics;
using System.Net.Http;
using BachelorProjectClient.Repository;
using BachelorProjectClient.Requests;
using BachelorProjectClient.Requests.RestRequests;

namespace BachelorProjectClient.TestCases.RestTestCases
{
    class MySqlTestCases
    {
        public static void TestCase1(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase1(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase1.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase2(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase2(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase2.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase3(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase3(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase3.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase4(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase4(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase4.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase5(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase5(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase5.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase6(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase6(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase6.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase7(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase7(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase7.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase8(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase8(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase8.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase9(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase9(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase9.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase10(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase10(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase10.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase11(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase11(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase11.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase12(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase12(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase12.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase13(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase13(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase13.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase14(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase14(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase14.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase15(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase15(clientId * iteration);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase15.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase16(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase16(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase16.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase17(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase17(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase17.ToString(),
                Enums.Enums.API.REST.ToString());
        }
        public static void TestCase18(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = RestMySqlRequests.CreateTestCase18(clientId * iteration, clientId * iteration + 100);
            Requests.ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase18.ToString(),
                Enums.Enums.API.REST.ToString());
        }

    }
}
