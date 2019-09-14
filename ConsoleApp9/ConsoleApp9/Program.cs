using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient d = new WebClient();
            d.Headers[HttpRequestHeader.ContentType] = "application/json";
            string responce = d.UploadString("http://192.168.36.129:5003/users/SendEmail","{\"sybject\":\"9221\"}");
            Console.WriteLine(responce);
        }
    }
}
