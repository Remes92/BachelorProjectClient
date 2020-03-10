using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests.RestRequests
{
    class RestMySqlRequests
    {
        public static HttpRequestMessage CreateTestCase1(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase1.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase2(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase2.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase3(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase3.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase4(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase4.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase5(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase5.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase6(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase6.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase7(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase7.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase8(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase8.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase9(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase9.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase10(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase10.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase11(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase11.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase12(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase12.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase13(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase13.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase14(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase14.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase15(int id)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase15.ToString() + "?id={0}", id));
        }
        public static HttpRequestMessage CreateTestCase16(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase16.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase17(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase17.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
        public static HttpRequestMessage CreateTestCase18(int lower, int upper)
        {
            return RestHttpRequest.MySqlRequest(string.Format(Enums.Enums.TestCases.TestCase18.ToString() + "?lower={0}&upper={1}", lower, upper));
        }
    }
}
