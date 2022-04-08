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
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSTiengViet
{
    internal class Program
    {
        static void ShowHeaders(HttpResponseHeaders headers)
        {
            Console.WriteLine("Headers");
            foreach (var header in headers)
            {
                Console.WriteLine($"Header key: {header.Key}, header value: {header.Value}");
            }
        }
        public static async Task<string> GetPageContent(string url)
        {
            using var httpClient = new HttpClient();

            //httpClient.DefaultRequestHeaders.Add("")

            HttpResponseMessage message = await httpClient.GetAsync(url);
            //message.Headers
            ShowHeaders(message.Headers);

            string html = await message.Content.ReadAsStringAsync();

            return html;
        }
        static async Task Main(string[] args)
        {
            // Http request: http client 
            try
            {
                string url = "https://www.facebook.com";
                string task = await GetPageContent(url);


                //Console.WriteLine(task);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}