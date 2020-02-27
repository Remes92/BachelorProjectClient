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
            TestCases.ExecuteTestSuite.RunTestSuite1(1, 1, 1);
           // TestCases.ExecuteTestSuite.RunTestSuite2(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite3(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite4(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite5(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite6(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite7(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite8(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite9(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite10(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite11(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite12(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite13(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite14(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite15(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite16(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite17(1, 1, 1);
            TestCases.ExecuteTestSuite.RunTestSuite18(1, 1, 1);
            //TestCases.SoapTestCases.MongoTestCases.TestCase1(1, 2, 3);
            //for(int i = 1; i<=10; i++)
            //{
            //    for(int j = 1; j<=100; j++)
            //    {
            //        TestCases.ExecuteTestSuite.RunTestSuite1(i,j,1);
            //    }
            //}
        }
    }
}
