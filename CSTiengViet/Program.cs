using System;
using Newtonsoft.Json;
using MyLibrary;
using System.ComponentModel.DataAnnotations;

namespace CSTiengViet
{
    internal class Program
    {
        class classA
        {
            public void Action() => Console.WriteLine("Action A");
        }

        class classB
        {
            public void Action()
            {
                Console.WriteLine("Action B");
                var aClass = new classA();
                aClass.Action();
            }
        }


        static void Main(string[] args)
        {
            var bClass = new classB();
            bClass.Action();
        }
    }
}
