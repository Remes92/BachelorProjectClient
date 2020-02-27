using System;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using BachelorProjectClient.Enums;

namespace BachelorProjectClient.Requests.SoapRequests
{
    public class SoapRequestBody
    {
        private static readonly XNamespace ns = "http://schemas.xmlsoap.org/soap/envelope/";
        private static readonly XNamespace myns = "http://tempuri.org/";
        private static readonly XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        private static readonly XNamespace xsd = "http://www.w3.org/2001/XMLSchema";

        private static XDocument CreateSoapBody(string targetedMethod)
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
        public static XDocument CreateSoapBodyTestCase1(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            soapRequest.Root.Element(ns + "Body").Element(myns + targetedMethod).Add(new XElement(myns + "num", 1));
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase2(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase3(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase4(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase5(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase6(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase7(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase8(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase9(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase10(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase11(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase12(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase13(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase14(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase15(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase16(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase17(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }
        public static XDocument CreateSoapBodyTestCase18(string targetedMethod)
        {
            XDocument soapRequest = CreateSoapBody(targetedMethod);
            return soapRequest;
        }

    }
}
