using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
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
            RunExperiment();
        }

        private static void RunExperiment()
        {
            //STARTUP 
            TestCases.GraphQLTestCases.MongoTestCases.TestCase1(0, 1, 4);
            TestCases.GraphQLTestCases.MySqlTestCases.TestCase1(0, 1, 4);
            TestCases.RestTestCases.MongoTestCases.TestCase1(0, 1, 4);
            TestCases.RestTestCases.MySqlTestCases.TestCase1(0, 1, 4);
            TestCases.SoapTestCases.MongoTestCases.TestCase1(0, 1, 4);
            TestCases.SoapTestCases.MySqlTestCases.TestCase1(0, 1, 4);


            for (int i = 1; i <= 10; i++)
            {
                Thread thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite1(i, 1));
                Thread thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite1(i, 2));
                Thread thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite1(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite2(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite2(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite2(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite3(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite3(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite3(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite4(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite4(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite4(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite5(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite5(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite5(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite6(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite6(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite6(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite7(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite7(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite7(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite8(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite8(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite8(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite9(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite9(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite9(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite10(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite10(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite10(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite11(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite11(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite11(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite12(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite12(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite12(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite13(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite13(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite13(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite14(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite14(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite14(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite15(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite15(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite15(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite16(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite16(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite16(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite17(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite17(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite17(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread1 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite18(i, 1));
                thread2 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite18(i, 2));
                thread3 = new Thread(() => TestCases.ExecuteTestSuite.RunTestSuite18(i, 3));
                thread1.Start();
                thread2.Start();
                thread3.Start();
                thread1.Join();
                thread2.Join();
                thread3.Join();
            }
        }
    }
}
