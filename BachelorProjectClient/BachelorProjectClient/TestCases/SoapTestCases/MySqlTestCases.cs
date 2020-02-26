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
    public class MySqlTestCases
    {
        public static void testCase1(int executionNO, int iteration, int clientId)
        {
            HttpRequestMessage request = SoapMySqlRequests.CreateTestCase1();
            ApiConnection.RunTestcase(executionNO, iteration, clientId, request,
                Enums.Enums.Databases.MySql.ToString(),
                Enums.Enums.TestCases.TestCase1.ToString(),
                Enums.Enums.API.SOAP.ToString());
        }
    }
}
