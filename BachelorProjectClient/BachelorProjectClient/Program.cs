using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient
{
    class Program
    {
        static void Main()
        {
            SoapService.SoapService soap = new SoapService.SoapService();
            Console.WriteLine(soap.HelloWorld());
            Console.ReadKey();
        }
    }
}
