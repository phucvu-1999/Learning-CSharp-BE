using System;
using Newtonsoft.Json;
using MyLibrary;
using System.ComponentModel.DataAnnotations;

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

        static void Main(string[] args)
        {
            IClassC classC = new C();
            IClassB classB = new B(classC);
            A classA = new A(classB);
            classA.ActionA();

        }
    }
}
