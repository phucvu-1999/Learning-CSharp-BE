using System;
using System.Collections.Generic;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
        static void Main(string[] args)
        {
            var newDictionary = new Dictionary<string, string>();
            newDictionary.Add("name", "Tien Phuc");
            newDictionary.Add("Age", "23");
            newDictionary.Add("hobby", "Football");
            newDictionary.Add("girlfriend", "Thanh Ha");

            Console.WriteLine(newDictionary["hobby"]);
        }
  }
}
