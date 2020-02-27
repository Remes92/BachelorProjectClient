using System;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;

namespace BachelorProjectClient.Requests.SoapRequests
{
    class SoapMySqlRequests
    {
        public static HttpRequestMessage CreateTestCase1()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase1(Enums.Enums.TestCases.TestCase1.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase2()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase2(Enums.Enums.TestCases.TestCase2.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase3()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase3(Enums.Enums.TestCases.TestCase3.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase4()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase4(Enums.Enums.TestCases.TestCase4.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase5()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase5(Enums.Enums.TestCases.TestCase5.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase6()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase6(Enums.Enums.TestCases.TestCase6.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase7()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase7(Enums.Enums.TestCases.TestCase7.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase8()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase8(Enums.Enums.TestCases.TestCase8.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase9()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase9(Enums.Enums.TestCases.TestCase9.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase10()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase10(Enums.Enums.TestCases.TestCase10.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase11()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase11(Enums.Enums.TestCases.TestCase11.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase12()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase12(Enums.Enums.TestCases.TestCase12.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase13()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase13(Enums.Enums.TestCases.TestCase13.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase14()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase14(Enums.Enums.TestCases.TestCase14.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase15()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase15(Enums.Enums.TestCases.TestCase15.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase16()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase16(Enums.Enums.TestCases.TestCase16.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase17()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase17(Enums.Enums.TestCases.TestCase17.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
        public static HttpRequestMessage CreateTestCase18()
        {
            HttpContent content = new StringContent(SoapRequestBody.CreateSoapBodyTestCase18(Enums.Enums.TestCases.TestCase18.ToString() + Enums.Enums.Databases.MySql.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
    }
}
