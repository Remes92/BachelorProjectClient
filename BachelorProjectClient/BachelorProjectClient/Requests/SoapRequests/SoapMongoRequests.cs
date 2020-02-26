using System;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;


namespace BachelorProjectClient.Requests.SoapRequests
{
    public class SoapMongoRequests
    {
        public static HttpRequestMessage CreateTestCase1()
        {
            HttpContent content = new StringContent(SoapHttpRequest.CreateSoapBody(Enums.Enums.TestCases.TestCase1.ToString() + Enums.Enums.Databases.Mongo.ToString()).ToString(), Encoding.UTF8, "text/xml");
            HttpRequestMessage request = SoapHttpRequest.RequestMessage();
            request.Content = content;
            return request;
        }
    }
}
