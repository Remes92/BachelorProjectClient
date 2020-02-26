using System;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;

namespace BachelorProjectClient.Requests
{
    public class SoapHttpRequest
    {
        private static readonly XNamespace ns = "http://schemas.xmlsoap.org/soap/envelope/";
        private static readonly XNamespace myns = "http://tempuri.org/";
        private static readonly XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        private static readonly XNamespace xsd = "http://www.w3.org/2001/XMLSchema";
        private const string soapUrl = "https://localhost:44361/SoapService.asmx?wsdl";

        public static XDocument CreateSoapBody(string targetedMethod)
        {
            XDocument soapRequest = new XDocument(
                new XElement(ns + "Envelope",
                    new XAttribute(XNamespace.Xmlns + "xsi", xsi),
                    new XAttribute(XNamespace.Xmlns + "xsd", xsd),
                    new XAttribute(XNamespace.Xmlns + "soap", ns),
                    new XElement(ns + "Body",
                        new XElement(myns + targetedMethod)
                   )
                ));

            return soapRequest;
        }

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
