using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http:";
            using (ServiceReference1.SomeSoapServiceClient W = new ServiceReference1.SomeSoapServiceClient())
            {
                var arg = new ServiceReference1.SendEmail();
                arg.sybject = Console.ReadLine();
                var res = W.SendEmail(arg).SendEmailResult;
                Console.WriteLine($"Result: {res}");
            }
        }
    }
}
