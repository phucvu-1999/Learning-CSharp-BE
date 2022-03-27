using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;


namespace CSTiengViet
{
  internal class Program
  {
        static void DoSomething(int seconds, string message, ConsoleColor colors)
        {
            lock(Console.Out)
            {
                Console.ForegroundColor = colors;
                Console.WriteLine("Start ... ");
                Console.ResetColor();
            }

            for(int i = 0; i < seconds; i++)
            {
                lock(Console.Out)
                {
                    Console.ForegroundColor = colors;
                    Console.WriteLine($"{message}: {i}");
                    System.Threading.Thread.Sleep(1000);
                    Console.ResetColor();
                }
            }

            lock (Console.Out)
            {
                Console.ForegroundColor = colors;
                Console.WriteLine("End ... ");
                Console.ResetColor();
            }
        }
        
        static async Task Task2()
        {
            var task2 = new Task(() => DoSomething(3, "Task 2", ConsoleColor.Blue));
            task2.Start();

            await task2;

            Console.WriteLine("Successfully imlement task 2");
        }
        static async Task Task3()
        {
            var task3 = new Task(() => DoSomething(3, "Task 3", ConsoleColor.White));
            task3.Start();

            await task3;
            Console.WriteLine("Task 3 successfully implement");
        }

        static async Task<string> Task4()
        {
                       
            var task4 = new Task<string>(() =>
            {
                DoSomething(5, "Task 4", ConsoleColor.White);
                return "Return form task 4";
            });

            task4.Start();
            var kq = await task4;
            Console.WriteLine("Successfully implement task 4");
            return kq;
        }

        static async Task<string> Task5()
        {
            var task5 = new Task<string>((object obj) =>
            {
                string t = (string)obj;
                DoSomething(5, t, ConsoleColor.Yellow);

                return "Result return from taks5";
            }, "Task 5");

            task5.Start();
            var kq = await task5;
            Console.WriteLine("Successfully implement the task 5");
            return kq;
        }

        static async Task<string> GetWeb(string url)
        {
           var httpClient = new HttpClient();
           HttpResponseMessage content = await httpClient.GetAsync(url);
           string pageContent = await content.Content.ReadAsStringAsync();
            
            return pageContent;
        }

        static async Task Main(string[] args)
        {
            var pageContent = await GetWeb("https://google.com");
            Console.WriteLine(pageContent);
        }
  }
}
