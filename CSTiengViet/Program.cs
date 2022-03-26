using System;
using System.Collections.Generic;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; } 
            public double Price { get; set; }
            public string Origin { get; set; }

            public Product(int _id, string _name, double _price, string _origin)
            {
                Id = _id;
                Name = _name;
                Price = _price;
                Origin = _origin;
            }
        }
        static void Main(string[] args)
        { 
            var sortList = new SortedList<string, int>() { }
        }
  }
}
