using System;
using System.Collections.Generic;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
        static void Main(string[] args)
        {
           var newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);

            try
            {

            newStack.Pop();
            newStack.Pop();
            newStack.Pop();
            } catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(newStack.Count);
        }
  }
}
