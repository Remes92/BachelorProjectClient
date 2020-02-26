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
            for(int i = 1; i<=10; i++)
            {
                for(int j = 1; j<=100; j++)
                {
                    TestCases.ExecuteTestSuite.RunTestSuite1(i,j,1);
                }
            }
        }
    }
}
