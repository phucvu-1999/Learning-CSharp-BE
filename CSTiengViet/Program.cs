using System;
using System.Collections.Generic;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
        static void Main(string[] args)
        {
            var newQueue = new Queue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);

             Console.WriteLine($"The first element of the Queue is: {newQueue.Peek()}");

            try
            {

            newQueue.Dequeue();
            newQueue.Dequeue();
            newQueue.Dequeue();
            } catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(newQueue.Count);
        }
  }
}
