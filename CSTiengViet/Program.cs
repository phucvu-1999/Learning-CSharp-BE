using System;
using Newtonsoft.Json;

namespace CSTiengViet
{

    internal class Program
    {
        class Product
        {
            public string Name { get; set; }
            public DateTime Expiry { get; set; }
            public string[] Sizes { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }

            string json1 = @"{
                'Name': 'Iphone'
                'Expiry': '2022-03-27T00:00:00',
                'Sizes': ['small']
            }";

            Product convertPd = JsonConvert.DeserializeObject<Product>(json1);
            Console.WriteLine(convertPd.Name);
        }
    }
}
