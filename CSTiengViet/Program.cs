using System;
using System.Collections.Generic;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
        static void Main(string[] args)
        {
            var newDoublyLinkedList = new LinkedList<int>();
            var value1 = newDoublyLinkedList.AddFirst(1);
            var value2 = newDoublyLinkedList.AddLast(2);

            var value3 = newDoublyLinkedList.AddAfter(value2, 3);
            newDoublyLinkedList.AddLast(4);
            newDoublyLinkedList.AddLast(5);

            var newNode = newDoublyLinkedList.Last.Value;
            Console.WriteLine(newNode);

            
        }
  }
}
