﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests.RestRequests
{
    public class RestMongoRequests
    {
        public static HttpRequestMessage CreateTestCase1()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase1.ToString());
        }
        public static HttpRequestMessage CreateTestCase2()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase2.ToString());
        }
        public static HttpRequestMessage CreateTestCase3()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase3.ToString());
        }
        public static HttpRequestMessage CreateTestCase4()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase4.ToString());
        }
        public static HttpRequestMessage CreateTestCase5()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase5.ToString());
        }
        public static HttpRequestMessage CreateTestCase6()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase6.ToString());
        }
        public static HttpRequestMessage CreateTestCase7()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase7.ToString());
        }
        public static HttpRequestMessage CreateTestCase8()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase8.ToString());
        }
        public static HttpRequestMessage CreateTestCase9()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase9.ToString());
        }
        public static HttpRequestMessage CreateTestCase10()
        {
            return RestHttpRequest.MongoRequest(Enums.Enums.TestCases.TestCase10.ToString());
        }
    }
}
