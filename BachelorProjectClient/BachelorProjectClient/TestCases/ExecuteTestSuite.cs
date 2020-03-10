using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.TestCases
{
    public class ExecuteTestSuite
    {
        public static void RunTestSuite1(int executionNO, int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}",Enums.Enums.TestCases.TestCase1.ToString(),executionNO, clientId));
            for(int i = 1; i<=3; i++)
                GraphQLTestCases.MongoTestCases.TestCase1(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase1(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase1(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase1(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase1(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase1(executionNO, i, clientId);
        }

        public static void RunTestSuite2(int executionNO, int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase2.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase2(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase2(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase2(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase2(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase2(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++) 
                SoapTestCases.MySqlTestCases.TestCase2(executionNO, i, clientId);
        }
        public static void RunTestSuite3(int executionNO, int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase3.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase3(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase3(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase3(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase3(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase3(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase3(executionNO, i, clientId);
        }
        public static void RunTestSuite4(int executionNO, int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase4.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase4(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase4(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase4(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase4(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase4(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase4(executionNO, i, clientId);
        }
        public static void RunTestSuite5(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase5.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase5(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase5(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase5(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase5(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase5(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase5(executionNO, i, clientId);
        }
        public static void RunTestSuite6(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase6.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase6(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase6(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase6(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase6(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase6(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase6(executionNO, i, clientId);
        }
        public static void RunTestSuite7(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase7.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase7(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase7(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase7(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase7(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase7(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase7(executionNO, i, clientId);
        }
        public static void RunTestSuite8(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase8.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase8(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase8(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase8(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase8(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase8(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase8(executionNO, i, clientId);
        }
        public static void RunTestSuite9(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase9.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase9(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase9(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase9(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase9(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase9(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase9(executionNO, i, clientId);
        }
        public static void RunTestSuite10(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase10.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase10(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase10(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase10(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase10(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase10(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase10(executionNO, i, clientId);
        }
        public static void RunTestSuite11(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase11.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase11(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase11(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase11(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase11(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase11(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase11(executionNO, i, clientId);
        }
        public static void RunTestSuite12(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase12.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase12(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase12(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase12(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase12(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase12(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase12(executionNO, i, clientId);
        }
        public static void RunTestSuite13(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase13.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase13(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase13(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase13(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase13(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase13(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase13(executionNO, i, clientId);
        }
        public static void RunTestSuite14(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase14.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase14(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase14(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase14(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase14(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase14(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase14(executionNO, i, clientId);
        }
        public static void RunTestSuite15(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase15.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase15(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase15(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase15(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase15(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase15(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase15(executionNO, i, clientId);
        }
        public static void RunTestSuite16(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase16.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase16(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase16(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase16(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase16(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase16(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase16(executionNO, i, clientId);
        }
        public static void RunTestSuite17(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase17.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase17(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase17(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase17(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase17(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase17(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase17(executionNO, i, clientId);
        }
        public static void RunTestSuite18(int executionNO,  int clientId)
        {
            Console.WriteLine(string.Format("Initializing: {0}, executionNumber: {1}, By Client:  {2}", Enums.Enums.TestCases.TestCase18.ToString(), executionNO, clientId));
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MongoTestCases.TestCase18(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MongoTestCases.TestCase18(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MongoTestCases.TestCase18(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                GraphQLTestCases.MySqlTestCases.TestCase18(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                RestTestCases.MySqlTestCases.TestCase18(executionNO, i, clientId);
            for (int i = 1; i <= 3; i++)
                SoapTestCases.MySqlTestCases.TestCase18(executionNO, i, clientId);
        }
    }
}
