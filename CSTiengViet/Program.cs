using System;
using Newtonsoft.Json;
using MyLibrary;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

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

        public static IClassB CreateB1(IServiceProvider provider)
        {
            var b1 = new B1(provider.GetService<IClassC>(), "HEllo");
            return b1;
        }

        static void Main(string[] args)
        {

            var services = new ServiceCollection();

            services.AddSingleton<A, A>();
            services.AddSingleton<IClassB, B1>((provider) =>
            {
                var b1 = new B1(provider.GetService<IClassC>(), "This is implemented in class B1");
                return b1;
            });
            services.AddSingleton<IClassC, C>();

            var provider = services.BuildServiceProvider();

            A classA = provider.GetService<A>();
            classA.ActionA();
        }
    }
}