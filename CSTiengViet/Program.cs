using System;
using Newtonsoft.Json;
using MyLibrary;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace CSTiengViet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hostName = Dns.GetHostName();
            Console.WriteLine(hostName);

            string url = "https://www.youtube.com/watch?v=iJlAMzFy4yQ&list=PLwJr0JSP7i8BERdErX9Ird67xTflZkxb-&index=34";
            var uri = new Uri(url);

            var ipHostEntry = Dns.GetHostEntry(uri.Host);
            Console.WriteLine(ipHostEntry);

        }
    }
}