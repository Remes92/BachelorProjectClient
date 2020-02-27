using System;
using System.Net.Http;

namespace BachelorProjectClient.Requests
{
    public class SoapHttpRequest
    {
        private const string soapUrl = "https://localhost:44361/SoapService.asmx?wsdl";
        public static HttpRequestMessage RequestMessage()
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(soapUrl),
                Method = HttpMethod.Post
            };
            return request;
        }
    }
}
