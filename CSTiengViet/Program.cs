using System;
using Newtonsoft.Json;
using MyLibrary;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;

namespace CSTiengViet
{
    internal class Program
    {
        interface IClassB
        {
            public void ActionB();
        }

        interface IClassC
        {
            public void ActionC();
        }

        class C : IClassC
        {
            public void ActionC() => Console.WriteLine("Action in class C");
        }

        class C1 : IClassC
        {
            public void ActionC() => Console.WriteLine("This is the implement of class C");
        }

        class B : IClassB
        {
            IClassC c_dependency;
            public B(IClassC classC)
            {
                c_dependency = classC;
            }
            public void ActionB()
            {
                Console.WriteLine("Action in class B");
                c_dependency.ActionC();
            }
        }

        class B1 : IClassB
        {
            IClassC c_dependency;
            string message;

            public B1(IClassC _cDep, string _msg)
            {
                message = _msg;
                c_dependency = _cDep;
                Console.WriteLine("Action B1 is created!!!");
            }

            public void ActionB()
            {
                Console.WriteLine(message);
                c_dependency.ActionC();
            }

        }
        class A
        {
            IClassB b_dependency;

            public A(IClassB classB)
            {
                b_dependency = classB;
            }

            public void ActionA()
            {
                Console.WriteLine("Action in class A");
                b_dependency.ActionB();
            }
        }

        class Horn
        {
            public void Beep() => Console.WriteLine("Beep Beep");
        }

        class Car
        {
            public Horn horn { get; set; }
            public void Beep()
            {
                horn.Beep();
            }

        }

        public class MyServiceOptions
        {
            public string data1 { get; set; }
            public string data2 { get; set; }

        }

        public class MyService
        {
            public string data1 { get; set; }
            public string data2 { get; set; }

            public MyService(IOptions<MyServiceOptions> options)
            {
                var _options = options.Value;
                data1 = _options.data1;
                data2 = _options.data2;
            }

            public void PrintData() => Console.WriteLine($"{data1} /{data2}");

        }

        public class DogOptions
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Dogs
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void PrintInfo() => Console.WriteLine($"{Name} are {Age}");

            public Dogs(IOptions<DogOptions> options)
            {
                Name = options.Value.Name;
                Age = options.Value.Age;
            }
        }


        static void Main(string[] args)
        {
            try
            {

                IConfigurationRoot configurationRoot;
                ConfigurationBuilder configBuilder = new ConfigurationBuilder();
                configBuilder.SetBasePath(System.IO.Directory.GetCurrentDirectory());
                configBuilder.AddJsonFile("config.json");

                configurationRoot = configBuilder.Build();

                var readValue = configurationRoot.GetSection("section1").GetSection("key1").Value;
                Console.WriteLine(readValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}