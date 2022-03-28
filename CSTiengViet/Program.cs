using System;
using Newtonsoft.Json;
using MyLibrary;

namespace CSTiengViet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4300000;
            var result = ConvertMoneyToText.NumberToText(a);
            Console.WriteLine(result);
        }
    }
}
