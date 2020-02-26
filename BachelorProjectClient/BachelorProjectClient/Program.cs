using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using BachelorProjectClient.Requests;


namespace BachelorProjectClient
{
    class Program
    {
        static void Main()
        {
            for(int i = 0; i<10; i++)
            {
                TestCases.GraphQLTestCases.MySqlTestCases.testCase1(1, i, 3);
                TestCases.GraphQLTestCases.MongoTestCases.testCase1(1, i, 3);
                TestCases.RestTestCases.MongoTestCases.testCase1(1, i, 3);
                TestCases.RestTestCases.MySqlTestCases.testCase1(1, i, 3);
                TestCases.SoapTestCases.MongoTestCases.testCase1(1, i, 3);
                TestCases.SoapTestCases.MySqlTestCases.testCase1(1, i, 3);
            }
        }
    }
}
