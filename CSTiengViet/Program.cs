using System;
using System.Collections.Generic;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
        static void Main(string[] args)
        {
            var set1 = new HashSet<int>() { 1, 2, 3, 4, 5, 6, };
            var set2 = new HashSet<int>() { 4,5,6,7,8,9 };

            set1.UnionWith(set2);
            foreach(var value in set1)
            {
                Console.WriteLine(value);
            }

        }
  }
}
